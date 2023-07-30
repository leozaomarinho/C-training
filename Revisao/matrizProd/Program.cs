using matrizProd;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Bem vindo ao cadastro de produtos ----");
            int option;

            do {

                Console.WriteLine("O que você deseja fazer:");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine("1 - Cadastrar produtos");
                Console.WriteLine("2 - Listar  produtos");
                option = int.Parse(Console.ReadLine());

                if(option == 0)
                {
                    Console.WriteLine("Você escolheu sair! Até a proxima");
                }

            } while (option!=0);
             
        }
    }
}