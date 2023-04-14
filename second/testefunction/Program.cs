using System;


namespace TestandoFunctions {
   
    class Program { 
        static void Main(string[] args)
        {

            int n1, n2;


            Console.WriteLine("Digite o primeiro valor:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            n2 = int.Parse(Console.ReadLine());
            
            double resultado = Apresenta (n1,n2);

            Console.WriteLine($"O resultado é {resultado}");



        }

        static int  Apresenta(int n1,int n2) {

            int soma = n1 + n2;

            return soma;
        }
    }
    
    }