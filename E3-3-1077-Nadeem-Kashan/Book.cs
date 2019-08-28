using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3_1077_Nadeem_Kashan
{
    public class Book : IComparable
    {
        public string Name { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book() { }

        public Book(string name, DateTime publicationDate, decimal price)
        {
            Name = name;
            PublicationDate = publicationDate;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(obj);
        }
    }
}
