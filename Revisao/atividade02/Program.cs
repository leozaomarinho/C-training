using System;
using System.Globalization;

namespace Program {

    class Program {

        static void Main(string[] args) {

            double largura, altura, area, perimetro, diagonal;

            Console.WriteLine("Digite o valor da base:");
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor da altera:");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * altura;

            perimetro = (altura * 2) + (largura * 2);

            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine("Area =" +area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro =" + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal =" +diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}