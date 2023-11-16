using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int quant = 0;
            double vTotal = 0;
            double valor = 0;

            Console.WriteLine("Digite qual opção você vai querer: ");
            option = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual a quantidade desejada: ");
            quant = int.Parse(Console.ReadLine());

            if (option == 1) {
                valor = 4.00;

                vTotal = valor * quant;
                Console.WriteLine($"Total a pagar: {vTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (option == 2)
            {
                valor = 4.50;
                vTotal = valor * quant;
                Console.WriteLine($"Total a pagar: {vTotal.ToString("F2", CultureInfo.InvariantCulture)}");


            }
            else if(option == 3)
            {
                valor = 5.00;
                vTotal = valor * quant;
                Console.WriteLine($"Total a pagar: {vTotal.ToString("F2", CultureInfo.InvariantCulture)}");


            }
            else if (option == 4)
            {
                valor = 2.00;
                vTotal = valor * quant;
                Console.WriteLine($"Total a pagar: {vTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else
            {
                valor = 1.50;
                vTotal = valor * quant;

                Console.WriteLine($"Total a pagar: R${vTotal.ToString("F2",CultureInfo.InvariantCulture)}");
            }

            Console.ReadLine();


        }
    }
}