using System;

class Uri
{
    static void Main(string[] args)
    {
        int n,x, fora, dentro;
        Console.WriteLine("Digite o valor de um número inteiro:");
        n = int.Parse(Console.ReadLine());
        x = 0;
        fora = 0;
        dentro = 0;
        do {

            if (x >= 10 && x <= 20)
            {
                dentro += 1;
            }
            else
            {
                fora += 1;
            }

            x++;
        }while (x<n);

        Console.WriteLine($"{dentro} dentro.");
        Console.WriteLine($"{fora} fora.");
    }
}