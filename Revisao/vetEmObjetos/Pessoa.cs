
using System.Security.Cryptography.X509Certificates;

namespace vetEmObjetos
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }


        public Pessoa(string nome, int idade, string email) {
            this.Nome = nome;
            this.Idade = idade;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"Nome : {Nome}, Idade: {Idade}, Email: {Email}";
        }

       
    }
}
