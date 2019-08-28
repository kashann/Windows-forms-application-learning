using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    enum OccupationEnum
    {
	    Child = 5,
	    Student = 8,
	    Employee = 10
    }

    internal struct PersonStruct
    {
        #region Attributes
        public int Age;
        public string Name;
        #endregion

        public PersonStruct(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region OldCode
            /*
            var occupation = OccupationEnum.Employee;
            Console.WriteLine((int)occupation);

            var occupationId = 5;
            Console.WriteLine((OccupationEnum)occupationId);
             * */
            #endregion

            /*var p1 = new PersonStruct(21, "Name 1");
            var p2 = p1;

            p1.Age = 140;
            p1.Name += "a";

            Console.WriteLine(p1);
            Console.WriteLine(p2);*/

            /*var p1 = new Person(21, "Name 1");
            var p2 = p1;

            p1.SetAge(23);
            p1.Name = "Name 2";

            Console.WriteLine(p1);
            Console.WriteLine(p2);*/

            var p1 = new Person(23, "Name3");
            var p2 = new Person(23, "Name1");
            var p3 = new Person(32, "Name2");

            var pArray = new[] { p1, p2, p3 };

            var nameAsc = new PersonNameAsc();
            var nameDesc = new PersonNameDesc();

            Console.WriteLine("#ASC");
            Array.Sort(pArray, nameAsc);
            foreach (var person in pArray)
                Console.WriteLine(person);

            Console.WriteLine("#DESC");
            Array.Sort(pArray, nameDesc);
            foreach (var person in pArray)
                Console.WriteLine(person);
        }
    }
}
