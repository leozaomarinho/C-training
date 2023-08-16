using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEnumCompo.Entities
{
    internal class Product
    {
        public Double Name { get; set; }
        public Double Price { get; set; }

        public Product() { }
        public Product(Double name, Double price)
        {
            Name = name;
            Price = price;
        }
    }
}
