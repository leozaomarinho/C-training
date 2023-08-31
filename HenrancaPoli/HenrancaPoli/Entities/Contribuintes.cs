using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
    abstract class Contribuintes
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }



        public abstract double Tax()
        {

        }
    }
}
