using System;

class Program
{
    static void Main(string[] args)
    {
        int N;

        Console.WriteLine("Digite o valor de N:");
        N = int.Parse(Console.ReadLine());

        string[] vet = new string[N];

        for(int i = 0; i < N; i++)
        {
            vet[i] = Console.ReadLine();
        }
        Console.WriteLine("Nomes Digitados:");
        foreach(string val in vet)
        {
            Console.WriteLine(val);
        }
    }
}