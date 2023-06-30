using System;
using System.Globalization;

class URI {
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        double n1,n2, media = 0;

        n1 = double.Parse(vet[0]);
        n2 = double.Parse(vet[1]);

        while (n1 < 0 || n2 < 0)
        {
            Console.WriteLine("Nota invalida!");


            vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0]);
            n2 = double.Parse(vet[1]);

        }

        media = (n1 + n2) / 2;

        Console.WriteLine("media = "+media.ToString("F2", CultureInfo.InvariantCulture));

    }
}