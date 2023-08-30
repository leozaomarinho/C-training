using abstracao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao.Entities
{
    internal class Shape
    {
        public Color color { get; set; }


        public Shape() { }

        public Shape(Color color) { }
        public virtual double Area(double area) {
            return area;
        }
    }
}
