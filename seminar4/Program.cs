using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OldCode
            /*
            var p = new Person("Name 1", 21);

            //explicit cast to integer
            //var age = (int)p; //explicit
            int age = p; //implicit
            Console.WriteLine("Age: " + age);

            var p2 = new Person("Name 2", 22);

            if (p < p2)
                Console.WriteLine("p2 is older");
            */
            #endregion

            var employees = new List<Person>();
            employees.Add(new SoftwareDeveloper("Dev1", 21, new[] { "C#" }));
            employees.Add(new SoftwareDeveloper("Dev2", 21, new[] { "Java" }));
            employees.Add(new SoftwareDeveloper("Dev3", 21, new[] { "C++", "C#" }));
            employees.Add(new Manager("The Manager", 10));

            foreach (var employee in employees)
                Console.WriteLine(employee.ToString());

            //Display only the persons that know programming
            foreach(var employee in employees)
            {
                //throws InvalidCastException for the manager
                //var a = (IProgrammingLanguages)employee;

                // is and as operators
                //Report with the known programming languages
                if(employee is IProgrammingLanguages)
                {
                    var ipl = (IProgrammingLanguages)employee;
                    Console.WriteLine(string.Join(", ", ipl.Languages));
                }
            }

            //Report - containing the managers
            Console.WriteLine("#Managers");
            foreach(var employee in employees)
            {
                var manager = employee as Manager;
                if (manager != null)
                    Console.WriteLine(manager.Name);
            }
        }
    }
}
