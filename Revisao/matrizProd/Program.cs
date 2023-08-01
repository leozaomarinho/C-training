﻿using matrizProd;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Bem vindo ao cadastro de produtos ----");
            int option;

            Console.WriteLine("Quantos produtos você deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0;i<n;i++) {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade: ");
                int quant = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do produto: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                produtos[i] = new Produto(nome, preco, quant); 
            
            };

            do {

                Console.WriteLine("O que você deseja fazer:");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine("1 - Cadastrar produtos");
                Console.WriteLine("2 - Listar  produtos");
                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        Console.WriteLine("---- Você escolheu sair ----");
                        Console.WriteLine("Pressione qualquer tecla para encerrar o programa!");
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade do produto: ");
                        int quant = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor do produto: ");
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        int i = produtos.Length;
                        produtos[i+1] = new Produto(nome, preco, quant);
                        break;
                }

            } while (option!=0);
             
        }
    }
}