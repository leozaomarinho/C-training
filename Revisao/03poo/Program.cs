using _03poo;
using System;

namespace program {

    class Program
    {
        static void Main(string[] args)
        {
            Produto TV;

            TV = new Produto();

            Console.WriteLine("Adicionando produtos ao estoque:");

            Console.WriteLine("Digite o nome do produto:");
            TV.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            TV.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            TV.Quantidade = int.Parse(Console.ReadLine());


            int options =0;

            do {
                Console.WriteLine("O que você deseja fazer:");
                Console.WriteLine(" 0 - Ver valor total em estoque");
                Console.WriteLine(" 1 - Adicionar produtos ao estoque");
                Console.WriteLine(" 2 - Remover produtos do estoque");
                Console.WriteLine(" 3 - Sair");

                options = int.Parse(Console.ReadLine());

            } while (options!=3);
        }
    }
}