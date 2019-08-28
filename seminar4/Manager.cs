using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    class Manager:Person
    {
        public Manager(string name, int age):base(name, age)
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age;
        }
    }
}
