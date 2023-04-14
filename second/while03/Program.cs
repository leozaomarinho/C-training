using System;
using System.ComponentModel.Design;
using System.Security.AccessControl;

namespace While3 {

    class Program { 
    
        static void Main(string[] args)
        {

            int tipoComb, alcool, gasolina, diesel;
            


            Console.WriteLine("Qual o tipo de combustivel abastecido?");
            Console.Write("1- Alcool 2- Gasolina 3- Diesel 4- Sair");
            tipoComb = int.Parse(Console.ReadLine());

            while (tipoComb != 0) {

                Console.WriteLine("Qual o tipo de combustivel abastecido?");
                Console.Write("1- Alcool 2- Gasolina 3- Diesel 4- Sair");

                if (tipoComb == 0) {
                    Console.WriteLine("Muito Obrigado!");
                    break;
                }
                else if (tipoComb == 1) {

                    gasolina = gasolina + 1;
                
                };
               
                
            
            
            }

        }
    }

}