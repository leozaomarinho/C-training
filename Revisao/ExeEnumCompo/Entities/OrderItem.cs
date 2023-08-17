using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeEnumCompo.Entities;
using ExeEnumCompo.Entities.Enums;

namespace ExeEnumCompo.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal() {

            return Price * Quantity;
        }

        public override string ToString()
        {
          return  $"{Product.Name} , ${Price}, Quantity {Quantity}, Subtotal {SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
