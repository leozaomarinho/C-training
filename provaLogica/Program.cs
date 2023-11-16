using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int codPeca, quantPeca;
            double valorPeca, totalPagar =0;



            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o codigo da peça: ");
                codPeca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de peças: ");
                quantPeca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da peça: ");
                valorPeca = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                double total =(double) quantPeca * valorPeca;

                totalPagar += total;
               
            }

            Console.WriteLine($"Valor a pagar: {totalPagar.ToString("F2",CultureInfo.InvariantCulture)}");


        }



    }
}