using _06poo;
using System;
using System.Globalization;

namespace program
{

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota:");
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a terceira nota:");
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------------");
            aluno.Aprovacao();



        }
    }
}