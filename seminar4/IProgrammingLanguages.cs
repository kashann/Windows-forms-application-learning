using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    interface IProgrammingLanguages
    {
        string[] Languages { get; set; }
        bool Knows(string language);
    }
}
