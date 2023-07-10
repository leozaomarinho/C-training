using System;

class Program
{
    static void Main(string[] args)
    {
        int M, N;

        int [,] matriz;
        int soma = 0;

        Console.WriteLine("Digite a quantidade de linhas: ");
        string[] sup = Console.ReadLine().Split(' ');

        M = int.Parse(sup[0]);
        N = int.Parse(sup[1]);

        matriz = new int[M, N];

        for(int i =0; i <M; i++)
        {
            for(int j = 0; j < N; j++)
            {
                Console.WriteLine("Digite os numeros inteiros na mesma linha:");
                string[] vet = Console.ReadLine().Split(' ');

                matriz[i,j]= int.Parse(vet[j]);

                soma += matriz[i, j];


            }
        }

        Console.WriteLine(soma);


    }
}