using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCsharp
{
    [Serializable]
    public partial class Form1 : Form
    {
        
        private List<Car> _cars;

        ErrorProvider modelErrorProvider;
        

        ErrorProvider priceErrorProvider;
      

        ErrorProvider dateErrorProvider;
        
        DateTime firstDate;
     
        private string FileName;
        
          
        decimal price;
        public Form1()
        {
            InitializeComponent();
            _cars = new List<Car>();
            modelErrorProvider = new ErrorProvider();
            modelErrorProvider.SetIconAlignment(tbModel,ErrorIconAlignment.MiddleRight);
            priceErrorProvider = new ErrorProvider();
            priceErrorProvider.SetIconAlignment(tbPrice, ErrorIconAlignment.MiddleRight);
            dateErrorProvider = new ErrorProvider();
            firstDate = new DateTime(2010, 1, 1);
            FileName = "cars.bin";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DisplayCars()
        {
            lvCars.Items.Clear();
            foreach(var car in _cars)
            {
                ListViewItem lvi = new ListViewItem(car.Model);
                lvi.SubItems.Add(car.ManufacturingDate.ToShortDateString());
                lvi.SubItems.Add(car.Price.ToString());
                lvi.SubItems.Add(((int)car).ToString());
                lvCars.Items.Add(lvi);
                //lvCars.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car(tbModel.Text, decimal.Parse(tbPrice.Text), dateTimePicker1.Value);
            _cars.Add(car);
           
            DisplayCars();
           
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            string lastName = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(lastName))
            {
                e.Cancel = true; //prevents the user from changing the focus to another control

                modelErrorProvider.SetError((Control)sender, "The model should not be empty!");
            }
        }

        private void tbModel_Validated(object sender, EventArgs e)
        {
            modelErrorProvider.Clear();
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            string priceString = ((TextBox)sender).Text.Trim();
            
            if(!decimal.TryParse(priceString,out price))
                {
                e.Cancel = true;
                priceErrorProvider.SetError((Control)sender, "The price is not a numerical value");
                }


        }

        private void tbPrice_Validated(object sender, EventArgs e)
        {
            priceErrorProvider.Clear();
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Today || dateTimePicker1.Value < firstDate)
            {
                e.Cancel = true;
                dateErrorProvider.SetError((Control)sender, "Date must be after 01/01/2010 and before today");
            }

        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            dateErrorProvider.Clear();
        }

        private void btnPriceSortASC_Click(object sender, EventArgs e)
        {
            _cars.Sort((x, y) => x.Price.CompareTo(y.Price));
            DisplayCars();
        }

        private void btnPriceSortDESC_Click(object sender, EventArgs e)
        {
            _cars.Sort((y, x) => x.Price.CompareTo(y.Price));
            DisplayCars();
        }

        private void btnDateSortASC_Click(object sender, EventArgs e)
        {
            _cars.Sort((x, y) => x.ManufacturingDate.CompareTo(y.ManufacturingDate));
            DisplayCars();
        }

        private void btnDateSortDesc_Click(object sender, EventArgs e)
        {
            
            _cars.Sort((y, x) => x.ManufacturingDate.CompareTo(y.ManufacturingDate));
            DisplayCars();
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using(FileStream fs = File.Create(FileName))
            {
                formatter.Serialize(fs, _cars);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead(FileName))
            {
                _cars = (List<Car>)formatter.Deserialize(fs);
                DisplayCars();
            }
        }
    }
}
