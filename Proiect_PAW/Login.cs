using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Login : Form
    {
        ArrayList _persons = new ArrayList();
        private string username;
        private string password;

        public Login()
        {
            InitializeComponent();
        }

        public Login(string user, string pass)
        {
            username = user;
            password = pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\kashi\\Documents\\Visual Studio 2015\\Projects\\PAW_2018\\Proiect_PAW\\Proiect_PAW\\database.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Login where UserName='" + tb_login_user.Text + "' and Password='" + tb_login_password.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("You are now logged in!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu m = new Menu(); 
                m.ShowDialog();
                this.Close();
            }
            else
                if (tb_login_user.Text == "")
                    errorProvider.SetError(tb_login_user, "Enter username!");
            else 
                if (tb_login_password.Text == "")
                    errorProvider.SetError(tb_login_password, "Enter password!");
            else
                MessageBox.Show("Invalid Username or Password! Please try again!");
        }
    }

}

       
    


