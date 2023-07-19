using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu primeiro e segundo nome");
            string[] sup = Console.ReadLine().Split(' ');
            string nome = sup[0];
            string sobrenome = sup[1];

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine(JuntaNome(nome, sobrenome));

        }

        static string JuntaNome(string nome, string sobrenome)
        {
            return $"O nome completo é {nome} {sobrenome}.";
        }
    }
}