namespace Proiect_PAW
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeePersonalDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeJobDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeProfessionalExperienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeePersonalDetailToolStripMenuItem,
            this.editEmployeeJobDetailToolStripMenuItem,
            this.editEmployeeProfessionalExperienceToolStripMenuItem,
            this.showEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.addEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeePersonalDetailToolStripMenuItem
            // 
            this.editEmployeePersonalDetailToolStripMenuItem.Name = "editEmployeePersonalDetailToolStripMenuItem";
            this.editEmployeePersonalDetailToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.editEmployeePersonalDetailToolStripMenuItem.Text = "Edit Employee Personal Detail";
            this.editEmployeePersonalDetailToolStripMenuItem.Click += new System.EventHandler(this.editEmployeePersonalDetailToolStripMenuItem_Click);
            // 
            // editEmployeeJobDetailToolStripMenuItem
            // 
            this.editEmployeeJobDetailToolStripMenuItem.Name = "editEmployeeJobDetailToolStripMenuItem";
            this.editEmployeeJobDetailToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.editEmployeeJobDetailToolStripMenuItem.Text = "Edit Employee Job Detail";
            this.editEmployeeJobDetailToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeJobDetailToolStripMenuItem_Click);
            // 
            // editEmployeeProfessionalExperienceToolStripMenuItem
            // 
            this.editEmployeeProfessionalExperienceToolStripMenuItem.Name = "editEmployeeProfessionalExperienceToolStripMenuItem";
            this.editEmployeeProfessionalExperienceToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.editEmployeeProfessionalExperienceToolStripMenuItem.Text = "Edit Employee Professional Experience";
            // 
            // showEmployeeToolStripMenuItem
            // 
            this.showEmployeeToolStripMenuItem.Name = "showEmployeeToolStripMenuItem";
            this.showEmployeeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.showEmployeeToolStripMenuItem.Text = "Show Employee";
            this.showEmployeeToolStripMenuItem.Click += new System.EventHandler(this.showEmployeeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 533);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Meniu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeePersonalDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeJobDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeProfessionalExperienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
    }
}