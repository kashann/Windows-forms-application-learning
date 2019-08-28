namespace Proiect_PAW
{
    partial class AddEmployee
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
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveAddEmp = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_departament = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(69, 127);
            this.numeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(153, 22);
            this.numeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(69, 187);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(153, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Number";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(69, 235);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(153, 22);
            this.telefonTextBox.TabIndex = 5;
            this.telefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonTextBox_KeyPress);
            // 
            // btnSaveAddEmp
            // 
            this.btnSaveAddEmp.Location = new System.Drawing.Point(95, 341);
            this.btnSaveAddEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAddEmp.Name = "btnSaveAddEmp";
            this.btnSaveAddEmp.Size = new System.Drawing.Size(100, 28);
            this.btnSaveAddEmp.TabIndex = 6;
            this.btnSaveAddEmp.Text = "Save";
            this.btnSaveAddEmp.UseVisualStyleBackColor = true;
            this.btnSaveAddEmp.Click += new System.EventHandler(this.btnSaveAddEmp_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(69, 65);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(153, 22);
            this.idTextBox.TabIndex = 7;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Image = global::Proiect_PAW.Properties.Resources._1491084505_back_alt;
            this.button3.Location = new System.Drawing.Point(1, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 25);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cb_departament
            // 
            this.cb_departament.FormattingEnabled = true;
            this.cb_departament.Items.AddRange(new object[] {
            "IT",
            "HR",
            "Relatii Clienti",
            "Logistica",
            "Marketing",
            "Vanzari"});
            this.cb_departament.Location = new System.Drawing.Point(69, 287);
            this.cb_departament.Margin = new System.Windows.Forms.Padding(4);
            this.cb_departament.Name = "cb_departament";
            this.cb_departament.Size = new System.Drawing.Size(153, 24);
            this.cb_departament.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Departament";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_departament);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnSaveAddEmp);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployee";
            this.Text = "Add employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Button btnSaveAddEmp;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_departament;
        private System.Windows.Forms.Label label6;
    }
}