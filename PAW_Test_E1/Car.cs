using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Test_E1
{
    [Serializable]
    public class Car
    {
        public String Model { get; set; }
        public decimal Price { get; set; }
        private DateTime _manufacturingDate;

        public DateTime ManufacturingDate
        {
            get { return _manufacturingDate; }
            set{
                if (DateTime.Now < _manufacturingDate)
                    throw new InvalidManufacturingDateException(value);
                else
                    _manufacturingDate = value;
            }
        }

        public Car() { }

        public Car(String model, decimal price, DateTime manufacturingDate)
        {
            Model = model;
            Price = price;
            ManufacturingDate = manufacturingDate;
        }
    }
}
