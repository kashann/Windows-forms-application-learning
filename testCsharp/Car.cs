using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCsharp
{[Serializable]
    public class Car
    {
        
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime ManufacturingDate { get; set; }
        
        public Car(string model,decimal price,DateTime manufacturingDate)
        {
            Model = model;
            Price = price;
            ManufacturingDate = manufacturingDate;
        }

        public int Compare(Car x, Car y)
        {
            return x.Price.CompareTo(y.Price);
        }
        public static explicit operator int(Car c)
        {
            return DateTime.Today.Year - c.ManufacturingDate.Year;

        }
        
    }
}
