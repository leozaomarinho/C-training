using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        int M, N;

        int [,] matriz;
        int soma=0;
        int[] resultado; 

        Console.WriteLine("Digite a quantidade de linhas: ");
        string[] sup = Console.ReadLine().Split(' ');

        M = int.Parse(sup[0]);
        N = int.Parse(sup[1]);

        matriz = new int[M, N];

        resultado = new int[M];



        for(int i =0; i <M; i++)
        {

            Console.WriteLine("Digite os numeros inteiros na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');

            for (int j = 0; j < N; j++)
            {
               

                matriz[i,j]= int.Parse(vet[j]);

                soma += matriz[i, j];



               

           
            }
            resultado[i] = soma;
            soma = 0;
        }

        for (int index = 0; index < M; index++)
        {
            Console.WriteLine(resultado[index]);
        }


        Console.WriteLine("---------Fim do programa---------");
        Console.ReadLine();

    }
}