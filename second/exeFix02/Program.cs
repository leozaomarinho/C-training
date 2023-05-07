using System.Globalization;

namespace exercicio
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome;
            int quartos;
            double precoProd;
            string[] vetor;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (tudo na mesma linha):");
            vetor = Console.ReadLine().Split(' ');

            Console.WriteLine("----------- SAIDA -------------");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);



        }

    }

}