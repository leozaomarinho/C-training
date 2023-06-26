using System;
using System.Globalization;


namespace calculaIdade
{
    class Programa {

        static void Main(string[] args)
        {
            string nome1,nome2;
            double p1, p2, media;

            Console.WriteLine("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (p1 + p2) / 2;

            Console.WriteLine("A idade media de "+nome1+ " e "+nome2+" é de: "+ media.ToString("F1",CultureInfo.InvariantCulture) + " anos");



        }
    
    }

}