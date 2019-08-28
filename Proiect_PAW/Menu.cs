using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW;
using System.IO;


namespace Proiect_PAW
{
    public partial class Menu : Form
    {
        //ArrayList listaPers = new ArrayList();
        List<Person> persoane = new List<Person>();
        public Menu()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddEmployee frm = new AddEmployee(listaPers);
        //    frm.ShowDialog();
        {
            using (AddEmployee f = new AddEmployee())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    persoane.Add(f.Rezultat);
                   // AfisarePersoane();
                }


            }
        }

        private void AfisarePersoane()
        {
            throw new NotImplementedException();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now logged out!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployee se = new ShowEmployee();
            se.ShowDialog();
        }

        private void editEmployeePersonalDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployeePersonal eep = new EditEmployeePersonal();
            eep.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Grafic gf = new Grafic();
            gf.ShowDialog();
        }

        private void editEmployeeJobDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployeeJob eej = new EditEmployeeJob();
            eej.ShowDialog();
        }
    }
}
