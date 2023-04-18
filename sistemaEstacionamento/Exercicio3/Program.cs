using Exercicio3;
using System;

namespace Estacionamento {
    class Program { 
    



        static void Main(string[] args)
        {

           

            int opcao = 0;


            while (opcao!= 0)
            {
                Console.WriteLine("Seleciona o que você deseja fazer:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Cadastrar veiculo");
                Console.WriteLine("4 - Lista de veiculos");
                Console.WriteLine("5 - Registrar entrada");
                Console.WriteLine("6 - Registrar saida");
                Console.WriteLine("7 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    
                    case 1:
                        Console.WriteLine("Você escolheu cadastrar o cliente:");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Listar clientes:");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu cadastrar veiculos:");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu listar Veiculos:");
                        break;
                    case 5:
                        Console.WriteLine("Você escolheu registrar entrada:");
                        break;
                    case 6:
                        Console.WriteLine("Você escolheu registrar saida:");
                        break;
                    case 7:
                        Console.WriteLine("Você escolheu sair do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }


            }




        }
    
    }

}