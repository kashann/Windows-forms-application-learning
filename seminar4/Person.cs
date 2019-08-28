using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }

        //cast - explicit / implicit
        public static implicit operator int(Person p)
        {
            return p.Age;
        }

        public static bool operator < (Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static bool operator > (Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
    }
}
