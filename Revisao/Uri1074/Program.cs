using System;

class Uri
{
    static void Main(string[] args)
    {
        int N,val;

        Console.WriteLine("Digite a quantidade de valores que serão digitados:");
        N = int.Parse(Console.ReadLine());
        int i = 0;

        do {

            Console.WriteLine("Digite o valor:");
            val = int.Parse(Console.ReadLine());

            if (val % 2 ==0)
            {
                if (val > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (val ==0)
                {
                    Console.WriteLine("NULL");
                }
                else {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }
            else
            {
                if (val > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (val == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }

            i++;
        
        }while(i<N);
    }
}