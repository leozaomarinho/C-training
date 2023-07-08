using System;

class Program
{
    static void Main(string[] args)
    {

        int quant;
        string[,] pessoas;

        Console.WriteLine("Digite a quantidade pessoas a serem inseridas:");
        quant=int.Parse(Console.ReadLine());

        pessoas = new string[quant, 2];

        for (int i=0;i<quant; i++)
        {
            for(int j = 0; j < 2; j++) {
                if (pessoas[i, j] == pessoas[i, 0])
                {
                    Console.WriteLine("Digite o nome:");
                    pessoas[i, j] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite a idade:");
                    pessoas[i, j] = Console.ReadLine();
                }
            }
        }

        for(int i = 0; i < quant; i++)
        {
            for (int j = 0;j < 2; j++)
            {
                Console.Write(pessoas[i, j]+' ');
            }
            Console.WriteLine();
        }




    }
}