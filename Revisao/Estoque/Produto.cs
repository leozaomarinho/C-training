using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        private string[,] Produtos;
        private int TotalProdutos;

       public Produto()
        {
            Produtos = new string[500,3];
            TotalProdutos = 0;
        }

        public void CadastrarProduto(string nome,double valor,int quantidade)
        {
            Produtos[TotalProdutos, 0] = nome;
            Produtos[TotalProdutos, 1] = valor.ToString(CultureInfo.InvariantCulture);
            Produtos[TotalProdutos,2] = quantidade.ToString();
            TotalProdutos++;
 
        }

        public void ListarProdutos()
        {
            for (int i = 0; i < TotalProdutos; i++)
            {
                Console.WriteLine($"Produto: {Produtos[i,0]}, Valor do produto: {Produtos[i,1]}, Quantidade do produto: {Produtos[i,2]}");
            }
        }

        public override string ToString()
        {
            return $"Nome : {Produtos[TotalProdutos,0]}, Valor do produto: {Produtos[TotalProdutos,1]}, Quantidade do produto: {Produtos[TotalProdutos,2]}";
        }

    }
}
