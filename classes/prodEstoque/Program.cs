using prodEstoque;
using System;
using System.Globalization;

    namespace Estoque {

    class ProdEstoque { 
    
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome do produto:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço do produto:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto:");
            p.Quant = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto:"+p);

            Console.Write("Digite a quantidade de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados:" +p);

            Console.Write("Digite a quantidade de produtos a serem removidos do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados:" + p);


        }

    }

}

