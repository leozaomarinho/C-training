using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite as duas notas do aluno na mesma linha: ");
        string[] vet = Console.ReadLine().Split(' ');
        double n1 = 0, n2 = 0, media = 0;
        int x = 0;

        n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);


        while (x != 2)
        {

            if (n1 <= 10 && n1 >= 0 && n2 <= 10 && n2 >= 0)
            {
                media = (n1 + n2) / 2;
                Console.WriteLine("Media =" + media.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {

                Console.WriteLine("nota invalida.");

            }

           

            Console.WriteLine("novo calculo: (1 - sim 2 - não )");
            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Digite as duas notas do aluno na mesma linha: ");
                vet = Console.ReadLine().Split(' ');

                n1 = double.Parse((vet[0]), CultureInfo.InvariantCulture);
                n2 = double.Parse((vet[1]), CultureInfo.InvariantCulture);
            }
            else {

                Console.WriteLine("Você optou por não fazer um novo calculo, programa encerrado!");
                break;
            }

            
        }



    }

}