using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeEnumCompo.Entities;
using ExeEnumCompo.Entities.Enums;

namespace ExeEnumCompo.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public Double Price { get; set; }

        public Product() { }
        public Product(String name, Double price)
        {
            Name = name;
            Price = price;
        }
    }
}
