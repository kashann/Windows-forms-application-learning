using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PawProject
{
    public partial class MainForm : Form
    {
        #region Attributes
        private List<Employee> _employees;
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Employees.mdb;";
        #endregion

        public MainForm()
        {
            InitializeComponent();
            _employees = new List<Employee>();
        }
        
        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmployees();
                DisplayEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Do you want to save before closing?", "Save",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        this.btnSerialize.PerformClick();
        //    }
        //}
        #endregion

        #region AddEditViewDelete
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var email = tbEmail.Text;
            var department = cbDepartment.Text;
            var gender = cbGender.Text;
            var job = tbJob.Text;
            var salary = int.Parse(tbSalary.Text);
            var course = cbCourse.Text;

            var employee = new Employee(new Person(name, email, department, gender),
                new Job(job, salary), new Course(course));
            try
            {
                AddEmployee(employee);
                DisplayEmployees();
                tbName.Clear();
                tbEmail.Clear();
                cbDepartment.ResetText();
                cbGender.ResetText();
                tbJob.Clear();
                tbSalary.Clear();
                cbCourse.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DisplayEmployees()
        {
            lvEmployees.Items.Clear();
            foreach (var employee in _employees)
            {
                var lvi = new ListViewItem(employee.person.name);
                lvi.SubItems.Add(employee.person.gender);
                lvi.SubItems.Add(employee.person.email);
                lvi.SubItems.Add(employee.person.department);
                lvi.SubItems.Add(employee.job.job);
                lvi.SubItems.Add(employee.job.salary.ToString());
                lvi.SubItems.Add(employee.course.course);
                lvi.Tag = employee;

                lvEmployees.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvEmployees.SelectedItems[0];
                Employee employee = (Employee)selectedItem.Tag;

                if (MessageBox.Show("Are you sure?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        DeleteEmployee((Employee)lvEmployees.SelectedItems[0].Tag);
                        DisplayEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
                MessageBox.Show("Select only one entry!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvEmployees.SelectedItems[0];
                Employee employee = (Employee)selectedItem.Tag;

                EditForm editForm = new EditForm(employee);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayEmployees();
                }                    
            }
            else
                MessageBox.Show("Select only one employee!", "Error");
        }
        #endregion

        #region Textboxes
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            var name = tbName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                e.Cancel = true;
                epText.SetError(tbName, "Mandatory field!");
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            epText.Clear();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = tbEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = true;
                epText.SetError(tbEmail, "Mandatory field!");
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            epText.Clear();
        }

        private void tbSalary_Validating(object sender, CancelEventArgs e)
        {
            var salary = tbSalary.Text.Trim();

            if (string.IsNullOrWhiteSpace(salary) || int.Parse(salary) < 0 || int.Parse(salary) > 30000)
            {
                e.Cancel = true;
                epSalary.SetError(tbSalary, "Wrong input!");
            }
        }

        private void tbSalary_Validated(object sender, EventArgs e)
        {
            epSalary.Clear();
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        #endregion

        #region Serializable
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _employees);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _employees = (List<Employee>)formatter.Deserialize(stream);
                DisplayEmployees();
            }
        }

        private void btnExportReportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";
            saveFileDialog.FileName = "employees.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Employee (M/F), email from Department has the Job (Salary) and attends Course");

                    foreach (var employee in _employees)
                    {
                        sw.WriteLine("Employee {0} ({1}) (email: {2}) from {3} has the Job: {4} (salary: {5}) and attends " +
                            "the {6} course", employee.person.name, employee.person.gender, employee.person.email,
                            employee.person.department, employee.job.job, employee.job.salary, employee.course.course);
                    }
                }
            }
        }

        private void importNewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (.txt)| *.txt|Excel File (.csv)| *.csv";
            openFileDialog.Title = "Open file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string[] strArray;
                    while (sr.Peek() >= 0)
                    {
                        strArray = sr.ReadLine().Split(';');
                        var employee = new Employee(new Person(strArray[0], strArray[1], strArray[2],
                            strArray[3]), new Job(strArray[4], int.Parse(strArray[5])), new Course(strArray[6])); 
                        _employees.Add(employee);
                    }
                    sr.Close();
                }
                DisplayEmployees();
            }
        }
        #endregion

        #region AltShortcuts
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.D)
            {
                this.serializationToolStripMenuItem.ShowDropDown();
                if (e.Alt && e.KeyCode == Keys.S)
                {
                    this.btnSerialize.PerformClick();
                }
                else if (e.Alt && e.KeyCode == Keys.D)
                {
                    this.btnDeserialize.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.E)
            {
                this.exportReportToolStripMenuItem.ShowDropDown();
                if (e.Alt && e.KeyCode == Keys.T)
                {
                    this.btnExportReportTxt.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.I)
            {
                this.importNewEmployeesToolStripMenuItem.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.P)
            {
                this.btnPrintMenu.ShowDropDown();
                if (e.Alt && e.KeyCode == Keys.P)
                {
                    this.btnPrint.PerformClick();
                }
                else if (e.Alt && e.KeyCode == Keys.V)
                {
                    this.btnPrintPreview.PerformClick();
                }
                else if (e.Alt && e.KeyCode == Keys.S)
                {
                    this.btnPageSetup.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.S)
            {
                this.btnStatistics.PerformClick();
            }
        }
        #endregion

        #region Printing
        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private int _currentEmployeeIndex = 0;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 9);

            var pageSettings = printDocument.DefaultPageSettings;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            var intPrintAreaHeight = pageSettings.PaperSize.Height - marginTop - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - marginLeft - pageSettings.Margins.Right;


            if (printDocument.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            const int rowHeight = 20;
            var columnWidth = intPrintAreaWidth / 7;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentEmployeeIndex < _employees.Count)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].person.name, font,
                    Brushes.Black, new RectangleF(currentX, currentY, columnWidth, rowHeight), fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth * 2, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].person.email, font,
                    Brushes.Black, currentX, currentY, fmt);
                currentX += columnWidth * 2;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].person.department, font,
                    Brushes.Black, currentX, currentY, fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth / 2, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].person.gender, font,
                    Brushes.Black, currentX, currentY, fmt);
                currentX += columnWidth / 2;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth * 3 / 2, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].job.job, font,
                    Brushes.Black, currentX, currentY, fmt);
                currentX += columnWidth * 3 / 2;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth / 2, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].job.salary.ToString(), font,
                    Brushes.Black, currentX, currentY, fmt);
                currentX += columnWidth / 2;

                e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, columnWidth * 3 / 2, rowHeight);
                e.Graphics.DrawString(_employees[_currentEmployeeIndex].course.course, font,
                    Brushes.Black, currentX, currentY, fmt);

                _currentEmployeeIndex++;
                currentY += rowHeight;

                if (currentY + rowHeight > intPrintAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentEmployeeIndex = 0;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
        #endregion

        #region Chart
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int m = 0;
            int f = 0;
            int mSal = 0;
            int fSal = 0;
            foreach (var emlpoyee in _employees)
            {
                if (emlpoyee.person.gender == "M")
                {
                    m++;
                    mSal += emlpoyee.job.salary;
                }
                else
                {
                    f++;
                    fSal += emlpoyee.job.salary;
                }
            }
            if (m != 0 && f != 0)
            {
                BarChartStats statsForm = new BarChartStats(m, mSal, f, fSal);
                statsForm.Show();
            }
            else
                MessageBox.Show("Not enough data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region DataBaseConnectivity
        public void AddEmployee(Employee employee)
        {
            var queryString = "INSERT INTO Employees (Nume, Email, Department, Gender, Job, " +
                              "Salary, Course) VALUES (@name, @email, @dep, @gender, @job, @salary, @course);";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                var insertCommand = new OleDbCommand(queryString, connection);
                var nameParam = new OleDbParameter("@name", employee.person.name);
                var emailParam = new OleDbParameter("@email", employee.person.email);
                var depParam = new OleDbParameter("@dep", employee.person.department);
                var genderParam = new OleDbParameter("@gender", employee.person.gender);
                var jobParam = new OleDbParameter("@job", employee.job.job);
                var salaryParam = new OleDbParameter("@salary", employee.job.salary);
                var courseParam = new OleDbParameter("@course", employee.course.course);
                insertCommand.Parameters.Add(nameParam);
                insertCommand.Parameters.Add(emailParam);
                insertCommand.Parameters.Add(depParam);
                insertCommand.Parameters.Add(genderParam);
                insertCommand.Parameters.Add(jobParam);
                insertCommand.Parameters.Add(salaryParam);
                insertCommand.Parameters.Add(courseParam);
                int affected = insertCommand.ExecuteNonQuery();

                if (affected == 1)
                {
                    var getIdCommand = new OleDbCommand("SELECT @@Identity;", connection);
                    employee.id = (int)getIdCommand.ExecuteScalar();

                    _employees.Add(employee);
                }
            }
        }

        public void LoadEmployees()
        {
            const string queryString = "SELECT * FROM Employees";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var employee = new Employee(
                            (int)sqlReader["Id"],
                            new Person(
                                (string)sqlReader["Nume"],
                                (string)sqlReader["Email"],
                                (string)sqlReader["Department"],
                                (string)sqlReader["Gender"]), 
                            new Job(
                                (string)sqlReader["Job"],
                                (int)sqlReader["Salary"]), 
                            new Course(
                                (string)sqlReader["Course"]));
                        _employees.Add(employee);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            const string queryString = "DELETE FROM Employees WHERE Id=@id";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                var idParameter = new OleDbParameter("@id", employee.id);
                sqlCommand.Parameters.Add(idParameter);
                int affected = sqlCommand.ExecuteNonQuery();

                if(affected == 1)
                    _employees.Remove(employee);
            }
        }
        #endregion
    }
}
