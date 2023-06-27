using System;
using System.Globalization;


namespace verifica { 
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Digite 3 valores na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(' ');

            int num1,num2,num3;


            num1 = int.Parse(vetor[0]);
            num2 = int.Parse(vetor[1]);
            num3 = int.Parse(vetor[2]);


                if (num1 <= num2 && num1 <= num3)
                {
                    Console.WriteLine("Menor ="+num1);
                  
                }
                else if (num2 <= num1 && num2 <= num3)
                {
                    Console.WriteLine("Menor ="+num2);
                   
                }
                else {
                    Console.WriteLine("Menor = "+num3);
                }

              
            }



        }
    }

