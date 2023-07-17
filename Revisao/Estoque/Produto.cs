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
            //Limitados o cadastro dos produtos a 500, para não haver a necessidade de criar uma logica para definir o tamanho da matriz
            Produtos = new string[500,3];
            TotalProdutos = 0;
        }

        //Utilizei uma matriz  na função de cadastro, onde a vertical é o total de produtos e a horizontal os campos dos produtos;
        public void CadastrarProduto(string nome,double valor,int quantidade)
        {
            Produtos[TotalProdutos, 0] = nome;
            Produtos[TotalProdutos, 1] = valor.ToString("F2",CultureInfo.InvariantCulture);
            Produtos[TotalProdutos,2] = quantidade.ToString();
            TotalProdutos++;
 
        }

        public void ListarProdutos()
            //utilizamos um loop for para imprimir os itens da matriz utilizando o Total de produtos cadastrados como index
        {
            for (int i = 0; i < TotalProdutos; i++)
            {
                Console.WriteLine($"| Produto: {Produtos[i,0]}, Valor do produto: {Produtos[i,1]}, Quantidade do produto: {Produtos[i,2]} |");
            }
        }

        public override string ToString()
        {
            return $"Nome : {Produtos[TotalProdutos,0]}, Valor do produto: {Produtos[TotalProdutos,1]}, Quantidade do produto: {Produtos[TotalProdutos,2]}";
        }

    }
}
