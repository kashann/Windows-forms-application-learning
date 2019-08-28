using System;
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
using System.Xml.Serialization;

namespace PAW_Test_E1
{
    public partial class MainForm : Form
    {
        private List<Car> _cars;

        public MainForm()
        {
            InitializeComponent(); 
            _cars = new List<Car>();
        }

        void DisplayCars(){
            lvCars.Items.Clear();
            foreach(var car in _cars){
                var lvi = new ListViewItem(car.Model);
                lvi.SubItems.Add(car.Price.ToString());
                lvi.SubItems.Add(car.ManufacturingDate.ToString());
                lvi.SubItems.Add((-(car.ManufacturingDate - DateTime.Now).Days/365.0).ToString());
                lvi.Tag = car;

                lvCars.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var model = tbModel.Text;
            var price = decimal.Parse(tbPrice.Text);
            var manufacturingDate = dtpManufacturingDate.Value;

            try
            {
                Car car = new Car(model, price, manufacturingDate);
                _cars.Add(car);
            }
            catch (InvalidManufacturingDateException imde)
            {
                MessageBox.Show("The manufacturing date " + imde.ManufacturingDate + " is invalid!");
            }

            DisplayCars();
            tbModel.Clear();
            tbPrice.Clear();
        }

        private void dtpManufacturingDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime date = new DateTime(2010, 1, 1);
            if(DateTime.Now < dtpManufacturingDate.Value){
                e.Cancel = true;
                epManDate.SetError(dtpManufacturingDate, "The manufacturing date is in the future!");
            }
            else if(date > dtpManufacturingDate.Value){
                e.Cancel = true;
                epManDate.SetError(dtpManufacturingDate, "The car is older than 2010!");
            }
        }

        private void dtpManufacturingDate_Validated(object sender, EventArgs e)
        {
            epManDate.Clear();
        }

        private void btnBinarySerialization_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _cars);
            }
        }

        private void btnBinaryDeserialization_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _cars = (List<Car>)formatter.Deserialize(stream);
                DisplayCars();
            }
        }

        private void btnXmlSerialization_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));
            using (StreamWriter stream = new StreamWriter("serialized.xml"))
            {
                formatter.Serialize(stream, _cars);
            }
        }

        private void btnXmlDeserialization_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Car>));
            using (StreamReader stream = new StreamReader("serialized.xml"))
            {
                _cars = (List<Car>)formatter.Deserialize(stream);
                DisplayCars();
            }
        }



    }
}
