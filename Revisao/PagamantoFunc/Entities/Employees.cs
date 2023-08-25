using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamantoFunc.Entities
{
    internal class Employees
    {
        public string Name { get; set; }
        public int Hour { get; set; }

        public double ValuePerHour { get; set; }


        public void Payment()
        {
            double pay = ValuePerHour * Hour;

            Console.WriteLine(pay.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
