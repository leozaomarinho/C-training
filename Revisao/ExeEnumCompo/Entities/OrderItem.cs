using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEnumCompo.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Double price)
        {
            this.Quantity = quantity;
            this.Price = price;
        }

        public void subTotal() { 
        
            
        }
    }
}
