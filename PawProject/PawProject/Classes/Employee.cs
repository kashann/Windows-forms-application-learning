using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProject
{
    [Serializable]
    public class Employee
    {
        public int id { get; set; }
        public Person person { get; set; }
        public Job job { get; set; }
        public Course course { get; set; }

        public Employee() { }

        public Employee(Person pers, Job munca, Course curs)
        {
            person = pers;
            job = munca;
            course = curs;
        }

        public Employee(int tag, Person pers, Job munca, Course curs) : this(pers, munca, curs)
        {
            id = tag;
        }
    }
}
