using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_PAW
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Diana\\Desktop\\Evenimente.mdb");
        OleDbDataReader dr;
        private void UserControl2_Load(object sender, EventArgs e)
        {
            connection.Open();
            string var = "select Locatie from Evenimente";
            OleDbCommand dc = new OleDbCommand(var, connection);
            dr = dc.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Locatie"]);

            }
            dr.Close();
            connection.Close();
        }
        public string location
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
           // connection.Open();
           // OleDbCommand dc = new OleDbCommand(" select count(*) from Evenimente where Locatie= '" + location + "'", connection);
           //// nr = Convert.ToInt16(dc.ExecuteReader());
           // connection.Close();
        }
    }
}