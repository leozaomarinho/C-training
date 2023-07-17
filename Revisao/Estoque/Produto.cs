using System;
using System.Collections.Generic;
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
            Produtos[TotalProdutos, 1] = valor.ToString();
            Produtos[TotalProdutos,2] = quantidade.ToString();
            TotalProdutos++;
 
        }

        public override string ToString()
        {
            return $"";
        }

    }
}
