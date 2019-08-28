using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProject
{
    [Serializable]
    public class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string gender { get; set; }

        public Person() { }

        public Person(string nume, string mail, string dep, string sex)
        {
            name = nume;
            email = mail;
            department = dep;
            gender = sex;
        }
    }
}
