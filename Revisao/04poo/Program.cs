using _04poo;
using System;
using System.Globalization;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;

            x = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo:");
            Console.Write("Largura :");
            x.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura :");
            x.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine($"AREA = {x.Area().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"PERIMETRO = {x.Perimetro().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine($"DIAGONAL = {x.Diagonal().ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}