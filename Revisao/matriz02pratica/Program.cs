using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de linhas da matriz:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de colunas da matriz:");
        int n = int.Parse(Console.ReadLine());

        int[,] dados;

        dados = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.WriteLine($"Digite um valor para armazenar na linha {i} na coluna {j}");
                dados[i,j] = int.Parse(Console.ReadLine());

            }
            
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"O valor da linha {i} da coluna {j} é {dados[i,j]}");

            }
            Console.WriteLine("-------------------------------------------------------------");

        }
    }
}