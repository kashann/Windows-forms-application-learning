using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProject
{
    [Serializable]
    public class Course
    {
        public string course { get; set; }

        public Course() { }

        public Course(string name)
        {
            course = name;
        }
    }
}
