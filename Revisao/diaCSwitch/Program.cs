using System;
namespace curso
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual o dia de hoje, sendo:");
            Console.WriteLine("1 - domingo");
            Console.WriteLine("2 - segunda");
            Console.WriteLine("3 - terça");
            Console.WriteLine("4 - quarta");
            Console.WriteLine("5 - quinta");
            Console.WriteLine("6 - sexta");
            Console.WriteLine("7 - sabado");

            int x = int.Parse(Console.ReadLine());

            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    Console.WriteLine("Hoje é " + dia);
                    break;
                case 2:
                    dia = "Segunda";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 3:
                    dia = "Terça";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 4:
                    dia = "Quarta";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 5:
                    dia = "Quinta";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 6:
                    dia = "Sexta";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 7:
                    dia = "Sabado";
                    Console.WriteLine("Hoje é " + dia + " Feira");
                    break;
                case 8:
                    Console.WriteLine("Digite um dia valido!");
                    break;
            }
        }
    }
}