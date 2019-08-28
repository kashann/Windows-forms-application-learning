using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCsharp
{
    class Class2 : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Model.CompareTo(y.Model);
        }
    }

}
