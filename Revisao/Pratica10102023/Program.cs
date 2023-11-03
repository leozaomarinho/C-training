using Pratica10102023.Entities;
using System;

namespace Pratica10102023
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produto = new List<Produto>();

            try
            {

                int option = 10;

                while (option != 0)
                {



                    Console.WriteLine("-- MENU --");
                    Console.WriteLine("1 - Cadastrar produto.");
                    Console.WriteLine("2 - Registrar venda.");
                    Console.WriteLine("3 - Verificar vendas.");
                    Console.WriteLine("4 - Listar produtos.");
                    Console.WriteLine("0 - Sair.");

                    option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você escolheu cadastrar um produto");
                        Console.WriteLine();

                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite o valor do produto: ");
                        double valor = double.Parse(Console.ReadLine());

                        Console.Write("Digite a quantidade do produto: ");
                        int quant = int.Parse(Console.ReadLine());

                        produto.Add(new Produto(nome, valor));
                    }

                    else if (option == 4)
                    {
                        foreach (Produto prod in produto)
                        {
                            Console.WriteLine(produto.ToString);
                        }
                    }

                }
            }





            catch
            {

            }



        }
    }
}
