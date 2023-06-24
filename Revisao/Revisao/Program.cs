using System;
using System.Globalization;


namespace curso
{

    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int quartos;
            double preco;
            string[] v;


            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura:");
            v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }


    }
}