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
            x.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura :");
            x.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine($"AREA = {x.Area()}");

            Console.WriteLine($"PERIMETRO = {x.Perimetro()}");

            Console.WriteLine($"DIAGONAL = {x.Diagonal()}");


        }
    }
}