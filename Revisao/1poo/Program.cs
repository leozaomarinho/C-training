using _1poo;
using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program {

    static void Main(string[] args)
    {

        Pessoa dupla;

        dupla = new Pessoa();

        Console.WriteLine("Digite o nome da primeira pessoa: ");
        dupla.P1 =Console.ReadLine();

        Console.WriteLine("Digite a idade da primeira pessoa: ");
        dupla.Id1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da segunda pessoa: ");
        dupla.P2 = Console.ReadLine();

        Console.WriteLine("Digite a idade da segunda pessoa: ");
        dupla.Id2 = int.Parse(Console.ReadLine());

           
       

            if (dupla.Id1 > dupla.Id2)
            {
                Console.WriteLine($"Pessoa mais velha: {dupla.P1}");
            }
            else if (dupla.Id2 > dupla.Id1)
            {
                 Console.WriteLine($"Pessoa mais velha: {dupla.P2}");
            }
            else
            {
              Console.WriteLine($"{dupla.P1} e {dupla.P2} possuem a mesma idade!");
            }


  

        Console.ReadLine();



    }

}