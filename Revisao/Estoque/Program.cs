﻿using Estoque;
using System;
using System.Globalization;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Produto produto = new Produto();

            do
            {
                Console.WriteLine("O que você deseja fazer: ");
                Console.WriteLine("1 - Cadastrar produtos.");
                Console.WriteLine("2 - Remover produtos.");
                Console.WriteLine("3 - Ver Estoque.");
                Console.WriteLine("0 - Sair.");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------");

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Você escolheu sair!");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("Você escolheu cadastrar um produto!");
                        Console.Write("Nome do produto:");
                        string nome = Console.ReadLine();
                        Console.Write("Valor do produto:");
                        double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.WriteLine("Quantidade do produto:");
                        int quant = int.Parse(Console.ReadLine());



                        produto.CadastrarProduto(nome, valor, quant);

                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Produto cadastrado com sucesso!");

                        Console.WriteLine("-----------------------------------------------------------------");


                        break;
                    case 3:
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Você escolheu listar os produtos:");
                        produto.ListarProdutos();
                        Console.WriteLine("-----------------------------------------------------------------");
                        break;
                }
            } while (opcao != 0);
        }
    }
}