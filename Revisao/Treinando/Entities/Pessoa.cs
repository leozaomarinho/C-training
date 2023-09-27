using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
       
        public string Sobrenome { get; set; }

        public int Cpf { get; set; }

        public Pessoa(string nome, string sobrenome, int cpf)
        {
            Nome = nome;
            Cpf = cpf;
            Sobrenome = sobrenome;
        }

        public Pessoa() { }

        public virtual void ApresentarSe()
        {
            Console.WriteLine($"Olá meu nome é {Nome} {Sobrenome}, prazer em conhece-lo");
        }
    }
}
