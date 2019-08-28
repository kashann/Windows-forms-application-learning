namespace Proiect_PAW
{
    partial class Login
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
            this.panel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.tb_login_user = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel.ContextMenuStrip = this.contextMenuStrip1;
            this.panel.Controls.Add(this.loginTitle);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.tb_login_password);
            this.panel.Controls.Add(this.tb_login_user);
            this.panel.Controls.Add(this.labelPass);
            this.panel.Controls.Add(this.labelUser);
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(416, 561);
            this.panel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 28);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginTitle.Location = new System.Drawing.Point(0, 0);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(367, 59);
            this.loginTitle.TabIndex = 8;
            this.loginTitle.Text = "Login Account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proiect_PAW.Properties.Resources.ee;
            this.pictureBox2.Location = new System.Drawing.Point(21, 343);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 4);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proiect_PAW.Properties.Resources.ee;
            this.pictureBox1.Location = new System.Drawing.Point(20, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 4);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(23, 425);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(365, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tb_login_password
            // 
            this.tb_login_password.AllowDrop = true;
            this.tb_login_password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_login_password.Location = new System.Drawing.Point(24, 308);
            this.tb_login_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login_password.Multiline = true;
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.PasswordChar = '*';
            this.tb_login_password.Size = new System.Drawing.Size(365, 28);
            this.tb_login_password.TabIndex = 4;
            // 
            // tb_login_user
            // 
            this.tb_login_user.AllowDrop = true;
            this.tb_login_user.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_login_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_login_user.Location = new System.Drawing.Point(24, 215);
            this.tb_login_user.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login_user.Multiline = true;
            this.tb_login_user.Name = "tb_login_user";
            this.tb_login_user.Size = new System.Drawing.Size(365, 23);
            this.tb_login_user.TabIndex = 3;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(17, 281);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(98, 25);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(16, 180);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(102, 25);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(444, 586);
            this.Controls.Add(this.panel);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tb_login_password;
        private System.Windows.Forms.TextBox tb_login_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    }
}