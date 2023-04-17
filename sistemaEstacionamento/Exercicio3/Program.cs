using System;

namespace Estacionamento {
    class Program { 
    



        static void Main(string[] args)
        {

            int opcao;


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

                opcao =int.Parse(Console.ReadLine());




            }




        }
    
    }

}