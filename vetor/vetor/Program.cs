using System;

class Progra
{
    static void Main(string[] args)
    {
        int N;
        string[] vet;
       

        N = int.Parse(Console.ReadLine());

        vet = new string[N];

        vet=Console.ReadLine().Split(' ');

        for(int i = 0; i < N; i++)
        {
            int num = 0;

            num = int.Parse(vet[i]);

            if (num<0)
            {
                Console.WriteLine($"{num}");
            }

        }
    }
}