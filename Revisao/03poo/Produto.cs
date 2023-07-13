using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03poo
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
           double total = Quantidade* Preco;

            return total;

        }

        public void AdicionarProdutos(int quant)
        {
            Quantidade += quant;

            Console.WriteLine($"Você adicionou {quant} unidades de {Nome} ao estoque.");
        }

        public void RemoverProdutos(int quant)
        {
            Quantidade -= quant;

            Console.WriteLine($"Você removeu {quant} unidades de {Nome} ao estoque. ");
        }

        public void VerEstoque()
        {
            Console.WriteLine($"Você possui {Quantidade} unidades de {Nome} em estoque.");
        }


    }
}
