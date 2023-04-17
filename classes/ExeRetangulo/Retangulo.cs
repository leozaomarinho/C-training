using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeRetangulo
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() {

            return Largura * Altura;
        
        }

        public double Perimetro() {

           double somaLargura = Largura * 2;
           double somaAltura = Altura * 2;

            return  somaAltura + somaLargura;
        
        }

        public double Diagonal()
        {
            return Math.Sqrt( Largura * Largura + Altura * Altura);


        }

    }
}
