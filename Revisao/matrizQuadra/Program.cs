using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,negativos =0;
            Console.Write("Digite o valor de N da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for(int j =0; j < n; j++)
                {
                    mat[i,j] = int.Parse(Console.ReadLine());

                    if (mat[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }
        }
    }
}