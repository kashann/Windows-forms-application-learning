namespace PawProject
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbJob = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(786, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(678, 112);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(765, 20);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(121, 22);
            this.tbSalary.TabIndex = 31;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(707, 23);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 17);
            this.lbSalary.TabIndex = 30;
            this.lbSalary.Text = "Salary:";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(394, 71);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(240, 22);
            this.tbJob.TabIndex = 29;
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
            this.cbCourse.Location = new System.Drawing.Point(725, 70);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(161, 24);
            this.cbCourse.TabIndex = 28;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(662, 73);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(57, 17);
            this.lbCourse.TabIndex = 27;
            this.lbCourse.Text = "Course:";
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.Location = new System.Drawing.Point(353, 73);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(35, 17);
            this.lbJob.TabIndex = 26;
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
            this.cbDepartment.Location = new System.Drawing.Point(106, 70);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(212, 24);
            this.cbDepartment.TabIndex = 25;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGender.Location = new System.Drawing.Point(350, 20);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(53, 24);
            this.cbGender.TabIndex = 24;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(284, 24);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 17);
            this.lbGender.TabIndex = 23;
            this.lbGender.Text = "Gender:";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(13, 74);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(86, 17);
            this.lbDepartment.TabIndex = 21;
            this.lbDepartment.Text = "Department:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(422, 23);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 20;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.AllowDrop = true;
            this.tbEmail.Location = new System.Drawing.Point(476, 21);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 22);
            this.tbEmail.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 23);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.AllowDrop = true;
            this.tbName.Location = new System.Drawing.Point(70, 21);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 22);
            this.tbName.TabIndex = 17;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 157);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbJob);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditForm";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
    }
}