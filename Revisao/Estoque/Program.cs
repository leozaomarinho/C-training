using Estoque;
using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("O que você deseja fazer: ");
            Console.WriteLine("1 - Cadastrar produtos.");
            Console.WriteLine("2 - Remover produtos.");
            Console.WriteLine("3 - Ver Estoque.");
            Console.WriteLine("0 - Sair.");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Você escolheu sair!");
                    break;
                case 1:
                    Console.WriteLine("Você escolheu cadastrar um produto!");
                    Console.Write("Nome do produto:");
                        string nome = Console.ReadLine();
                    Console.Write("Valor do produto:");
                        double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantidade do produto:");
                        int quant = int.Parse(Console.ReadLine());
                    break;
                case 2:
            }
        }
    }
}