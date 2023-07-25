using exerVetClass;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente[] clientes = new Cliente[10];

            Console.Write("Quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Aluguel {i}:");

                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email do cliente: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                clientes[i] = new Cliente(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (clientes[i] != null)
                {
                    Console.WriteLine($"{i} : {clientes[i]}");
                }

            }



        }
    }
}
