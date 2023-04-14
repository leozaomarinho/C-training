using System;


namespace While
{

    class Program
    {

        static void Main(string[] args)
        {

            int pass = 2002;

            Console.WriteLine("Digite sua senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != pass)
            {

                Console.WriteLine("Senha invalida!");
                Console.WriteLine("Digite sua senha!");
                senha = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("Acesso permitido!");



        }
    }

}