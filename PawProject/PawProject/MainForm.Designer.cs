namespace PawProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerialize = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserialize = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportReportTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.importNewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNewEmployee = new System.Windows.Forms.GroupBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbJob = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.epText = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip.SuspendLayout();
            this.gbNewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.exportReportToolStripMenuItem,
            this.importNewEmployeesToolStripMenuItem,
            this.btnPrintMenu,
            this.btnStatistics});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(925, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serializationToolStripMenuItem
            // 
            this.serializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerialize,
            this.btnDeserialize});
            this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            this.serializationToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.serializationToolStripMenuItem.Text = "&Data Serialization";
            // 
            // btnSerialize
            // 
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(157, 26);
            this.btnSerialize.Text = "&Serialize";
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(157, 26);
            this.btnDeserialize.Text = "&Deserialize";
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportReportTxt});
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.exportReportToolStripMenuItem.Text = "&Export Employees";
            // 
            // btnExportReportTxt
            // 
            this.btnExportReportTxt.Name = "btnExportReportTxt";
            this.btnExportReportTxt.Size = new System.Drawing.Size(129, 26);
            this.btnExportReportTxt.Text = ".&txt file";
            this.btnExportReportTxt.Click += new System.EventHandler(this.btnExportReportTxt_Click);
            // 
            // importNewEmployeesToolStripMenuItem
            // 
            this.importNewEmployeesToolStripMenuItem.Name = "importNewEmployeesToolStripMenuItem";
            this.importNewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.importNewEmployeesToolStripMenuItem.Text = "&Import new employees";
            this.importNewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.importNewEmployeesToolStripMenuItem_Click);
            // 
            // btnPrintMenu
            // 
            this.btnPrintMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrintPreview,
            this.btnPageSetup});
            this.btnPrintMenu.Name = "btnPrintMenu";
            this.btnPrintMenu.Size = new System.Drawing.Size(92, 24);
            this.btnPrintMenu.Text = "&Print menu";
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 26);
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(170, 26);
            this.btnPrintPreview.Text = "Print pre&view";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(170, 26);
            this.btnPageSetup.Text = "Page &setup";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(79, 24);
            this.btnStatistics.Text = "&Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // gbNewEmployee
            // 
            this.gbNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewEmployee.Controls.Add(this.tbSalary);
            this.gbNewEmployee.Controls.Add(this.lbSalary);
            this.gbNewEmployee.Controls.Add(this.tbJob);
            this.gbNewEmployee.Controls.Add(this.cbCourse);
            this.gbNewEmployee.Controls.Add(this.lbCourse);
            this.gbNewEmployee.Controls.Add(this.lbJob);
            this.gbNewEmployee.Controls.Add(this.cbDepartment);
            this.gbNewEmployee.Controls.Add(this.cbGender);
            this.gbNewEmployee.Controls.Add(this.lbGender);
            this.gbNewEmployee.Controls.Add(this.btnAdd);
            this.gbNewEmployee.Controls.Add(this.lbDepartment);
            this.gbNewEmployee.Controls.Add(this.lbEmail);
            this.gbNewEmployee.Controls.Add(this.tbEmail);
            this.gbNewEmployee.Controls.Add(this.lbName);
            this.gbNewEmployee.Controls.Add(this.tbName);
            this.gbNewEmployee.Location = new System.Drawing.Point(17, 34);
            this.gbNewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gbNewEmployee.Name = "gbNewEmployee";
            this.gbNewEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.gbNewEmployee.Size = new System.Drawing.Size(892, 133);
            this.gbNewEmployee.TabIndex = 1;
            this.gbNewEmployee.TabStop = false;
            this.gbNewEmployee.Text = "Add new employee";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(760, 28);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(121, 22);
            this.tbSalary.TabIndex = 16;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            this.tbSalary.Validating += new System.ComponentModel.CancelEventHandler(this.tbSalary_Validating);
            this.tbSalary.Validated += new System.EventHandler(this.tbSalary_Validated);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(702, 31);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 17);
            this.lbSalary.TabIndex = 15;
            this.lbSalary.Text = "Salary:";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(320, 79);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(190, 22);
            this.tbJob.TabIndex = 14;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Programming",
            "Management",
            "Logistics Optimizations",
            "Social Media",
            "Advertising",
            "Interviewing"});
            this.cbCourse.Location = new System.Drawing.Point(593, 79);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(161, 24);
            this.cbCourse.TabIndex = 13;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(530, 82);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(57, 17);
            this.lbCourse.TabIndex = 11;
            this.lbCourse.Text = "Course:";
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Location = new System.Drawing.Point(279, 81);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(35, 17);
            this.lbJob.TabIndex = 10;
            this.lbJob.Text = "Job:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "IT",
            "BI",
            "HR",
            "Logistics",
            "Marketing",
            "Sales"});
            this.cbDepartment.Location = new System.Drawing.Point(101, 78);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(171, 24);
            this.cbDepartment.TabIndex = 9;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGender.Location = new System.Drawing.Point(345, 28);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(53, 24);
            this.cbGender.TabIndex = 8;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(279, 32);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 17);
            this.lbGender.TabIndex = 7;
            this.lbGender.Text = "Gender:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(774, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(8, 82);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(86, 17);
            this.lbDepartment.TabIndex = 4;
            this.lbDepartment.Text = "Department:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(417, 31);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.AllowDrop = true;
            this.tbEmail.Location = new System.Drawing.Point(471, 29);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 22);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(8, 31);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.AllowDrop = true;
            this.tbName.Location = new System.Drawing.Point(65, 29);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 22);
            this.tbName.TabIndex = 0;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // lvEmployees
            // 
            this.lvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chGender,
            this.chEmail,
            this.chDepartment,
            this.chJob,
            this.chSalary,
            this.chCourse});
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.GridLines = true;
            this.lvEmployees.Location = new System.Drawing.Point(17, 175);
            this.lvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(891, 289);
            this.lvEmployees.TabIndex = 2;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 120;
            // 
            // chGender
            // 
            this.chGender.Text = "Gender";
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 160;
            // 
            // chDepartment
            // 
            this.chDepartment.Text = "Department";
            this.chDepartment.Width = 80;
            // 
            // chJob
            // 
            this.chJob.Text = "Job";
            this.chJob.Width = 130;
            // 
            // chSalary
            // 
            this.chSalary.Text = "Salary";
            // 
            // chCourse
            // 
            this.chCourse.Text = "Course";
            this.chCourse.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(804, 472);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(692, 472);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 28);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // epText
            // 
            this.epText.ContainerControl = this;
            // 
            // epSalary
            // 
            this.epSalary.ContainerControl = this;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 510);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvEmployees);
            this.Controls.Add(this.gbNewEmployee);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Human Resource Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbNewEmployee.ResumeLayout(false);
            this.gbNewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerialize;
        private System.Windows.Forms.ToolStripMenuItem btnDeserialize;
        private System.Windows.Forms.GroupBox gbNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ErrorProvider epText;
        private System.Windows.Forms.ErrorProvider epSalary;
        private System.Windows.Forms.ToolStripMenuItem btnExportReportTxt;
        private System.Windows.Forms.ToolStripMenuItem importNewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPrintMenu;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem btnPageSetup;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem btnStatistics;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chGender;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chDepartment;
        private System.Windows.Forms.ColumnHeader chJob;
        private System.Windows.Forms.ColumnHeader chCourse;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.ColumnHeader chSalary;
    }
}

