using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawProject
{
    [Serializable]
    public class Job
    {
        public string job { get; set; }
        public int salary { get; set; }

        public Job() { }

        public Job(string name, int wage)
        {
            job = name;
            salary = wage;
        }
    }
}
