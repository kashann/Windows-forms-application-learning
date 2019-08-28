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
    public partial class EditEmployeePersonal : Form
    {
       Image File;
        public EditEmployeePersonal()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan tSpan = to - from;
            double days = tSpan.TotalDays;
            textBox2.Text = (days / 365).ToString("0");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog()==DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog()==DialogResult.OK)
            {
                File.Save(f.FileName);
            }

        }
    }
}
