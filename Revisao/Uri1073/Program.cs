using System;

class Uri
{
    static void Main(string[] args)
    {
        int N,i=1, quadrado;
        

        Console.WriteLine("Digite o valor de N:");
        N = int.Parse(Console.ReadLine());

        do {

            if (i % 2 == 0)
            {
                quadrado =(int) Math.Pow(i,2);

                Console.WriteLine($"{i} ^ 2 = {quadrado}");
            }

            i++;
        } while (i<=N);
    }
}