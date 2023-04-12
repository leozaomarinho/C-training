using System;
using System.Globalization;

namespace Projeto02
{
    static class Projeto03
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preco é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preco é ${preco2:f2}");
            Console.WriteLine("");
            Console.WriteLine($"Registo: {idade} anos de idade, codigo {codigo} e genero: {genero}.");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida:f8}");
            Console.WriteLine($"arredondado:{medida:f3}");
            Console.WriteLine($"Separador decimal invariant cultute: {medida.ToString(CultureInfo.InvariantCulture)}");


        }
    }
}