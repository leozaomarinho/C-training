using System;
using System.Globalization;
using ExeRetangulo;

namespace exRetangulo { 

    class Program
    {

        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            
            Console.Write("Digite a largura do retangulo:");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retangulo:");
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area:{ret.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");




        }

    }

}