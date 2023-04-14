using System;


namespace Loops {

    class Program { 
        static void Main(string[] args)
        {

            int x;

            Console.WriteLine("Digite um número:");
            x = int.Parse(Console.ReadLine());

            while (x > 0)
            {

                Console.WriteLine("Digite outro número");
                x = int.Parse(Console.ReadLine());


            }



        }
    
    
    }
}