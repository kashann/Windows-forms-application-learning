using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Training //course
    {
        private string name { get; set; }
        private string location { get; set; }
        private string hour { get; set; }

        public Training(string nume, string locatie, string ora)
        {
            name = nume;
            location = locatie;
            hour = ora;
        }
        
    }
}
