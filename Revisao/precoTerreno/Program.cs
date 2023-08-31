using System;
using System.Globalization;


namespace Program { 

    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, precoMetroQuadrado;

            Console.WriteLine("Digite a largura do terreno:");
            largura= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            double valorTerreno = area * precoMetroQuadrado;

            Console.WriteLine("Total da area do terreno: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total do terreno: " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Alterando para teste");


        }
    }
   

}
