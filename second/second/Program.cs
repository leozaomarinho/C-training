using System;


namespace Projeto02
{

    public class Program
    {
        public static void Main(string[] args)
        {

            string c = "ABC";
            string d = "DEF";
            

            double a = 5;
            double b = 7;

            double resultado = 3;

            resultado += (a + b);

            Console.WriteLine($"O resultado da soma é : {resultado}");


            c += d;

            Console.WriteLine($"a concatenação é {c}");
        }
    }
}