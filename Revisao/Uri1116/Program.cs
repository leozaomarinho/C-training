using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        
        double resultado,x,y;
        string[] n = Console.ReadLine().Split(' ');

        x = double.Parse(n[0]);
        y = double.Parse(n[1]);

        while (x>=0 && y!=0)
        {
            resultado = (x / y);

            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));

            n = Console.ReadLine().Split(' ');

            x = double.Parse(n[0]);
            y = double.Parse(n[1]);

        };

        Console.WriteLine("divisão impossivel");
        Console.ReadLine();




    }

}