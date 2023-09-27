using System;
using Treinando.Entities;

namespace Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Pessoa> pessoas  = new List<Pessoa>();

            Console.WriteLine("Cadastro de pessoas:");

            Console.WriteLine("Qual o seu nome e sobrenome? ");
            string[] nomeCompleto = Console.ReadLine().Split(' ');

            string nome = nomeCompleto[0];
            string sobrenome = nomeCompleto[1];

            Console.WriteLine("Qual o seu CPF? ");
            int cpf = int.Parse(Console.ReadLine());
        }
    }
}
