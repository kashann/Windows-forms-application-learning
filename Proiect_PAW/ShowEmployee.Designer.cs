namespace Proiect_PAW
{
    partial class ShowEmployee
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showJobDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProfessionalExperienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEmployeeToolStripMenuItem,
            this.showJobDetailsToolStripMenuItem,
            this.showProfessionalExperienceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 70);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // showJobDetailsToolStripMenuItem
            // 
            this.showJobDetailsToolStripMenuItem.Name = "showJobDetailsToolStripMenuItem";
            this.showJobDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showJobDetailsToolStripMenuItem.Text = "Salary Calculator";
            this.showJobDetailsToolStripMenuItem.Click += new System.EventHandler(this.showJobDetailsToolStripMenuItem_Click);
            // 
            // showProfessionalExperienceToolStripMenuItem
            // 
            this.showProfessionalExperienceToolStripMenuItem.Name = "showProfessionalExperienceToolStripMenuItem";
            this.showProfessionalExperienceToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showProfessionalExperienceToolStripMenuItem.Text = "Training Planner";
            this.showProfessionalExperienceToolStripMenuItem.Click += new System.EventHandler(this.showProfessionalExperienceToolStripMenuItem_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "EmployeeId";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "ContactName";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ContactNumber";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail";
            this.columnHeader4.Width = 142;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(-1, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1047, 292);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
         //   this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
           // this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
          //  this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.//listView1_DragEnter);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Departament";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::Proiect_PAW.Properties.Resources._1491084505_back_alt;
            this.button1.Location = new System.Drawing.Point(-1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1044, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "ShowEmployee";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem showJobDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProfessionalExperienceToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}