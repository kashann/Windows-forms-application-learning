using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PawProject
{
    public partial class EditForm : Form
    {
        private Employee _employee;
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Employees.mdb;Persist Security Info=True";

        public EditForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbName.Text = _employee.person.name;
            cbGender.Text = _employee.person.gender;
            tbEmail.Text = _employee.person.email;
            cbDepartment.Text = _employee.person.department;
            tbSalary.Text = _employee.job.salary.ToString();
            tbJob.Text = _employee.job.job;
            cbCourse.Text = _employee.course.course;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _employee.person.name = tbName.Text;
                _employee.person.gender = cbGender.Text;
                _employee.person.email = tbEmail.Text;
                _employee.person.department = cbDepartment.Text;
                _employee.job.salary = int.Parse(tbSalary.Text);
                _employee.job.job = tbJob.Text;
                _employee.course.course = cbCourse.Text;
                UpdateEmployee(_employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            const string queryString = "UPDATE Employees SET Nume='@name', Email='@email', Department='@dep'," +
                                       "Gender='@gender', Job='@job', Salary=@salary, Course='@course' WHERE Id=@id";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                
                var nameParam = new OleDbParameter("@name", tbName.Text);
                var emailParam = new OleDbParameter("@email", tbEmail.Text);
                var depParam = new OleDbParameter("@dep", cbDepartment.Text);
                var genderParam = new OleDbParameter("@gender", cbGender.Text);
                var jobParam = new OleDbParameter("@job", tbJob.Text);
                var salaryParam = new OleDbParameter("@salary", tbSalary.Text);
                var courseParam = new OleDbParameter("@course", cbCourse.Text);
                sqlCommand.Parameters.Add(nameParam);
                sqlCommand.Parameters.Add(emailParam);
                sqlCommand.Parameters.Add(depParam);
                sqlCommand.Parameters.Add(genderParam);
                sqlCommand.Parameters.Add(jobParam);
                sqlCommand.Parameters.Add(salaryParam);
                sqlCommand.Parameters.Add(courseParam);
                int affected = sqlCommand.ExecuteNonQuery();

                if (affected == 1)
                {
                    var getIdCommand = new OleDbCommand("SELECT @@Identity;", connection);
                    employee.id = (int)getIdCommand.ExecuteScalar();
                }
            }
        }
    }
}
