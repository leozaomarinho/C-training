using System;
using System.Globalization;

namespace _04poo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public  double Area()
        {
           return (double) Largura * Altura;

           
        }

        public double Perimetro() {

            return  (Largura + Altura) * 2;

            
            
        }

        public double Diagonal()
        {
            return  Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura,2));

           ;
        }

        public override string ToString()
        {
            return $"Largura: {Largura} Altura: {Altura}";
        }
    }
}
