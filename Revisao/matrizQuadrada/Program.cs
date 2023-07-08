using System;

class Program
{
    static void Main(string[] args)
    {
        int N ,negativo=0;
        int[,] mat;

       

        Console.WriteLine("Digite o valor da matriz quadrada:");
        N = int.Parse(Console.ReadLine());


        mat = new int[N, N];

        for (int i =0;i<N;i++)
        {
            string[] s = Console.ReadLine().Split(' ');
           
            for (int j = 0; j < N; j++)
            {
                
                mat[i, j] = int.Parse(s[j]);

                if (mat[i, j] < 0)
                {
                    negativo++;
                }

            }
            
        }



        Console.WriteLine($"Diagonal principal: ");
            for(int i =0; i < N; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Quantidade de negativos: {negativo}");

    }
}