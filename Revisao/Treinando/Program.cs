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

            Console.WriteLine("Qual o seu nome e sobrenome? ex: 'Nome Sobrenome' ");
            string[] nomeCompleto = Console.ReadLine().Split(' ');

            string nome = nomeCompleto[0];
            string sobrenome = nomeCompleto[1];

            Console.WriteLine("Qual o seu CPF? ");
            int cpf = int.Parse(Console.ReadLine());

            pessoas.Add(new Pessoa(nome, sobrenome, cpf));

            Console.WriteLine("Você possui filhos? s/n");
            char filhos = char.Parse(Console.ReadLine());



            if (filhos == 's')
            {
                Console.WriteLine("Nome do filho: ");
                string nomeFilho = Console.ReadLine();

                Console.WriteLine("Nome do pai: ");
                string nomePai = Console.ReadLine();

                Console.WriteLine("Nome da mãe: ");
                string nomeMae = Console.ReadLine();

                pessoas.Add(new Filho(nomeFilho, sobrenome, cpf, nomePai,nomeMae));

                
            }
            else
            {
                Console.WriteLine("Cadastro concluido");
            }


        }
    }
}
