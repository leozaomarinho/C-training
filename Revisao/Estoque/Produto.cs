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

            if (TotalProdutos == 0)
            {
                Console.WriteLine("Não há produtos cadastrados no estoque!");
            }

            else
            {
                for (int i = 0; i < TotalProdutos; i++)
                {

                    Console.WriteLine($"| Produto: {Produtos[i, 0]} | Valor do produto: {Produtos[i, 1]} | Quantidade do produto: {Produtos[i, 2]} ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                }
            }
        }

        public void RemoverProdutos(string nome)
        {
            for(int i = 0; i < TotalProdutos; i++)
            {
                if (Produtos[i,0] == nome)
                // A partir do momento em que encontramos o produto com o nome correspondente,
                // vamos reorganizar a matriz de produtos para excluir o produto encontrado.
                // Fazemos isso movendo todos os produtos posteriores um índice para trás.

                // Começando do produto encontrado, percorremos todos os produtos subsequentes
                // até o penúltimo produto na matriz.
                {
                    for (int j =0; j<TotalProdutos - 1; j++)
                    // Movemos cada atributo do produto posterior para a posição atual do produto.
                    {
                        Produtos[j,0] = Produtos[j+1,0];
                        Produtos[j,1] = Produtos[j+1,1];
                        Produtos[j, 2] = Produtos[j+1,2];
                    }
                    // Agora, definimos os atributos do último produto na matriz como nulos,
                    // já que o último produto foi movido para a posição anterior.
                    Produtos[TotalProdutos - 1, 0] = null;
                    Produtos[TotalProdutos - 1, 1] = null;
                    Produtos[TotalProdutos - 1, 2] = null;

                    TotalProdutos--;

                    Console.WriteLine("Produto Removido com sucesso!");
                    break;
                }
            }
        }


        public override string ToString()
        {
            return $"Nome : {Produtos[TotalProdutos,0]}, Valor do produto: {Produtos[TotalProdutos,1]}, Quantidade do produto: {Produtos[TotalProdutos,2]}";
        }

    }
}
