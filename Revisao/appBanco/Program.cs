using appBanco;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente = new ContaBancaria();
            double saldoInicial = 0;

            Console.Write("Entre com o número da conta:");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta:");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial (s/n)?");
            string opDeposito = Console.ReadLine();

            if (opDeposito == "s") {

                Console.Write("Entre com o valor do deposito incial:");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            cliente.CriarConta(numConta, nomeTitular, saldoInicial);



        }
    }
}