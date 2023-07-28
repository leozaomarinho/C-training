using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>contato = new List<string>();

            string nome;
            int option;
            do
            {

                Console.WriteLine("Seja bem vindo a sua lista telefonica, o que deseja fazer?");
                Console.WriteLine("1 - Cadastrar contato.");
                Console.WriteLine("2 - Remover contato.");
                Console.WriteLine("3 - Visualizar contatos");
                Console.WriteLine("0 - sair.");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine();

                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Você escolheu sair!");
                        break;
                    case 1:
                        Console.WriteLine();

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Você escolheu cadastrar um novo contato!");
                        Console.Write("Digite o nome do contato: ");
                        nome = Console.ReadLine();

                        contato.Add(nome);

                        Console.WriteLine("Contato cadastrado com sucesso!");


                        break;
                        case 2:
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Você escolheu remover um contato!");
                        Console.Write("Digite o nome do contato que você deseja remover: ");


                        break;
                        case 3:
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");

                        Console.WriteLine("Você escolheu ver a lista de contatos!");
                        foreach (string contatos in contato)
                        {
                            Console.WriteLine($" Nome : {contatos}");
                        }

                        Console.WriteLine("--------------------------------------------------------------");


                        break;
                }

            }
            while (option != 0);

        }

        
    }
}

