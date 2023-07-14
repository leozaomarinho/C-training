using _05poo;
using System;
using System.Globalization;

namespace curso{

    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario p1 = new Funcionario();

            Console.WriteLine("Digite os dadaos do funcionario:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            p1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            p1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(p1);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p1.AumentarSalario(aumento);

            Console.WriteLine(p1);

        }
    }

}