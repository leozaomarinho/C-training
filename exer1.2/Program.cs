using System;
using System.Globalization;

namespace Curso
{
    class Program
    {

        static void Main(string[] args)
        {
            double raio;

            Console.WriteLine("Digite o valor do raio de um circulo:");
            raio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(raio,2);


            Console.WriteLine($"A = {area.ToString("F4",CultureInfo.InvariantCulture)}");
        }
    }
}