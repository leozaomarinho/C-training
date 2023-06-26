using System;
using System.Globalization;


namespace calculaIdade
{
    class Programa {

        static void Main(string[] args)
        {
            double p1, p2, media;

            Console.WriteLine("Digite a idade da primeira pessoa:");
            p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a idade da segunda pessoa:");
            p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (p1 + p2) / 2;

            Console.WriteLine("A idade media de maria e joaquim é de: "+media+" anos");



        }
    
    }

}