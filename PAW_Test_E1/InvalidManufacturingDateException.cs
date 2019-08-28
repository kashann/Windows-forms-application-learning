using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAW_Test_E1
{
    class InvalidManufacturingDateException : Exception
    {
        public DateTime ManufacturingDate { get; set; }
        public InvalidManufacturingDateException(DateTime manufacturingDate)
        {
            ManufacturingDate = manufacturingDate;
        }
    }
}
