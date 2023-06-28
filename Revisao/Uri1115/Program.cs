using System;
using System.ComponentModel.Design;

class URI
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int x, y;

        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        while (x != 0 && y != 0)
        {

            if (x > 0 && y > 0)
            {
                Console.WriteLine("O ponto está no primeiro quadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("O ponto está no segundo quadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("O ponto está no terceiro quadrante.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("O ponto está no quarto quadrante.");
            }
            else
            {
                Console.WriteLine("O ponto está no quadrante nulo.");
            }

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Um dos pontos esta no quadrante Nulo!");


    }
}