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
            ContaBancaria cliente;
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
                cliente = new ContaBancaria(numConta, nomeTitular, saldoInicial);
            }

            else
            {
                cliente = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine(cliente);
            int opcao = 0;

            do
                {
                    Console.WriteLine("O que você deseja fazer?");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine("1 - Realizar um deposito");
                    Console.WriteLine("2 - Realizar um Saque");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    double valor;

                    Console.Write("Digite o valor a ser depositado:");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    cliente.Deposito(valor);
                    Console.WriteLine(cliente);
                }
                else if (opcao ==2) {

                    double valor;

                    Console.Write("Digite o valor do saque a ser realizado:");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    cliente.Saque(valor);
                    Console.WriteLine(cliente);
                }
                else
                {
                    Console.WriteLine("Você escolheu sair!");
                }

                }while (opcao!=0) ;
            
            



        }
    }
}