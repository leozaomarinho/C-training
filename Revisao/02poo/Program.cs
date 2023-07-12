using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Digite o valor de A:");
                a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());

            soma(a, b);

        }


        static void soma(int a,int b)
        {
            int resultado = a + b;

            Console.WriteLine($"{resultado}");

        }
    }
}