using carrosValor;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bem vindo ao cadastro de veiculos ---");
            Console.Write("Quantos veiculos você deseja cadastrar? ");
            int quant = int.Parse(Console.ReadLine());

            Veiculos[] veic = new Veiculos[quant];
        }

        public static void listar()
        {
            

        }
    }


   
}