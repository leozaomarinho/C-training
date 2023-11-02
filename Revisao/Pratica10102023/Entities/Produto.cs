using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica10102023.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }



        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
          

        }


        public override string ToString()
        {
            return $"Nome: {Nome} , Valor : {Preco}";
        }

    }
}
