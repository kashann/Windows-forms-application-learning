using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Person
    {
        public string EmployeeId;
        public string ContactName;
        public string ContactNumber;
        public string Email;
        public string Departament;
        String[] gender = new String[] {"M","F"};

        public Person(string id, string nume, string nr, string email, string dep)
        {
            EmployeeId = id;
            ContactName = nume;
            ContactNumber = nr;
            Email = email;
            Departament = dep;
        }

        public override string ToString()
        {
           return  "Employee " + this.ContactName + " (id #" + this.EmployeeId + ") has the following data: " + this.ContactNumber + " " + this.Email + " " + this.Departament + "\r\n";
        }

    }
}
