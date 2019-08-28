using Proiect_PAW.Utile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class ShowEmployee : Form
    {
        List<Person> persoane;
        public ShowEmployee()
        {            
            InitializeComponent();
            persoane = SerializeItems.DeserializePersoane();//new List<Persoana>();
            //persoane.Add(new Persoana("1", "Douglas Grant", "650.507.9844", "DGRANT", "IT"));
            //persoane.Add(new Persoana("2", "Mary Jane", "650.508.9944", "MJANEE", "IT"));
            //persoane.Add(new Persoana("3", "Michael Scotfield", "655.557.9844", "SCOTTFIELD", "HR"));
            //persoane.Add(new Persoana("4", "John Walsh", "650.507.9833", "JWALSH", "HR"));
            //persoane.Add(new Persoana("5", "Timothy Gates", "650.000.9844", "TGATES", "Logistica"));
            //persoane.Add(new Persoana("6", "Jennifer Dilly", "660.507.9844", "JDILLY", "Vanzari"));
            //persoane.Add(new Persoana("7", "Madison Beer", "650.588.9844", "MBEER", "Vanzari"));
            //persoane.Add(new Persoana("8", "Jake Jalinski", "650.507.9844", "JJAKE", "Logistica"));
            //persoane.Add(new Persoana("9", "Sarah Bell", "777.507.9844", "SBELLE", "Marketing"));
            //persoane.Add(new Persoana("10", "Jane Jeniffer", "650.666.9844", "JJENIFER", "Marketing"));
            //persoane.Add(new Persoana("11", "Julia Delinger", "660.507.9844", "JDELINGER", "Relatii clientii"));
            //persoane.Add(new Persoana("12", "Davin Smith", "650.507.9855", "DSMITH", "HR"));
            //persoane.Add(new Persoana("13", "Wiliam Wentworth", "650.557.9844", "WWENTWORTH", "IT"));
            //persoane.Add(new Persoana("14", "Julia Carey", "650.507.9944", "JCAREY", "Marketing"));
            //persoane.Add(new Persoana("15", "Andrew Dawnson", "650.547.9844", "ADAWNSON", "IT"));
            //persoane.Add(new Persoana("16", "John Michael", "650.447.9844", "JMICHEAL", "Relatii clientii"));
            AfisarePersoane();
        }
        public void AfisarePersoane()
        {
            listView1.Items.Clear();
            foreach (Person pers in persoane)
            {
                ListViewItem item = new ListViewItem(new string[] { pers.EmployeeId, pers.ContactName, pers.ContactNumber, pers.Email, pers.Departament.ToString() });
                item.Tag = pers;
                listView1.Items.Add(item);
            }
            SerializeItems.DeserializePersoane();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Person pers = listView1.SelectedItems[0].Tag as Person;
                if (MessageBox.Show("Are you sure ?", "Delete employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    persoane.Remove(pers);
                    AfisarePersoane();
                }
            }
        }


        //private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (AddEmployee f = new AddEmployee())
        //    {
        //        if (f.ShowDialog() == DialogResult.OK)
        //        {
        //            persoane.Add(f.Rezultat);
        //            AfisarePersoane();
        //        }
        //    }
        //}

        private void showJobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Person pers = listView1.SelectedItems[0].Tag as Person;
                // if (MessageBox.Show("Are you sure ?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EditEmployeeJob f3 = new EditEmployeeJob();
                    f3.ShowDialog();
                }
            }
        }

        private void showProfessionalExperienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Person pers = listView1.SelectedItems[0].Tag as Person;
                Form f4 = new Form4();
                f4.ShowDialog();
            }
        }
    }
}
    