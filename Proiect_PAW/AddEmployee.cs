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
using Proiect_PAW.Utile;

namespace Proiect_PAW
{
    public partial class AddEmployee : Form
    {        
        Person pers = null;
        ArrayList listaPersoane = new ArrayList();
        ArrayList listaNoua = new ArrayList();

        public AddEmployee()
        {
            InitializeComponent();           
        }
        
        private void btnSaveAddEmp_Click(object sender, EventArgs e)
        {
            Person persoana = new Person(this.idTextBox.Text, this.numeTextBox.Text,this.telefonTextBox.Text, this.emailTextBox.Text,this.cb_departament.Text);
            SerializeItems.SerializePersoane(persoana);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nume = numeTextBox.Text;
            string numarTelefon = telefonTextBox.Text;
            string email = emailTextBox.Text;
            string dep = cb_departament.Text;
            Person p = new Person(id, nume, numarTelefon, email,dep);
            // SerializeItems.SerializePersoane(p);
            listaPersoane.Add(p);
            MessageBox.Show("The employee has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idTextBox.Clear();
            numeTextBox.Clear();
            telefonTextBox.Clear();
            emailTextBox.Clear();
            
            //   this.DialogResult = DialogResult.OK;
          //  Close();
        }


        public Person Rezultat { get { return pers; } }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "jpg|*.jpg";
        //    DialogResult rez = openFileDialog1.ShowDialog();
        //    if(rez==DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        //    }
        //}

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
        
        private void telefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //public void Afiseaza(object sender, EventArgs e)
        //{
        //    textBox1.Clear();
        //    foreach (Persoana p in listaPersoane)
        //        textBox1.Text += "Angajatul " + p.ContactName + " are id-ul " + p.employeeId + " si urmatoarele date de contact: " + p.ContactNumber + p.Email + "\r\n";
        //}


        //private void button4_Click(object sender, EventArgs e)
        //{

        //   listaNoua = listaPersoane;
        //    foreach (Persoana p in listaNoua) { 

        //        textBox1.Text += p.ToString() + Environment.NewLine;
        //       // Console.WriteLine(p.ToString());
        //    }

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    foreach (Persoana p in listaNoua)

        //    textBox1.Clear();
        //}        
    }
}
 