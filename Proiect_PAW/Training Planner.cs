using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW;
using System.Data.OleDb;

namespace Proiect_PAW
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\kashi\\Documents\\Visual Studio 2015\\Projects\\PAW_2018\\Proiect_PAW\\Proiect_PAW\\database.mdb");
        DataSet ds = new DataSet();
        DataTable dt;
        DataView dv;

        private void import_Click(object sender, EventArgs e)
        {            
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Evenimente", connection);
            da.Fill(ds,"Evenimente");
            dt = ds.Tables["Evenimente"];
            dv = new DataView(dt);
            dv.RowFilter = "Locatie='" + userControl11.location + "'";
            dataGridView1.DataSource = dv;
        }
    }
}


        

    

       
        
    
