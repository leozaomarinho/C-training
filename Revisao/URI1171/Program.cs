using System;
using System.Threading.Channels;

class Program {

    static void Main(string[] args)
    {
        int x, y, menor, maior, soma=0;

        Console.WriteLine("Digite o primeiro valor:");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            menor = x;
            maior = y;

        }
        else
        {
            menor = y;
            maior = x;
        }

        for(int i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }

            else
            {
                continue;
            }
        };

        Console.WriteLine($"A soma dos números impares do intervalo é: {soma}");
    }

}