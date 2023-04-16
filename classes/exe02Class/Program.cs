using exe02Class;
using System;
using System.Globalization;

namespace Objetos
{

    class Program
    {

        static void Main(string[] args)
        {

            double media;

            Funcionario pessoa = new Funcionario();
            Funcionario pessoa2 = new Funcionario();



            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome:");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salario:");
            pessoa.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome:");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (pessoa.Salario + pessoa2.Salario) / 2;

            Console.WriteLine($"Sálario medio: {media.ToString("F2", CultureInfo.InvariantCulture)}");





        }


    }

}