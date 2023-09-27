using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando.Entities
{
    public class Filho : Pessoa
    {

        public string NomePai { get; set; }
        public string NomeMae { get; set; }


        public Filho() { }

        public Filho(string nome, string sobrenome, int cpf, string nomePai, string nomeMae)
          :  base(nome, sobrenome, cpf )
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            NomePai = nomePai;
            NomeMae = nomeMae;

        }

        public override void ApresentarSe()
        {
            base.ApresentarSe();
            Console.WriteLine($"Sou filho de {NomePai} com {NomeMae}");
        }


    }
}
