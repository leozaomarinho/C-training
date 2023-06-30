using System;
using System.ComponentModel.Design;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {
        int alcool=0, gasolina=0, diesel= 0, opcao, cont = 0;

        Console.WriteLine("Digite qual opção você deseja:");
        Console.WriteLine("1 - Alcool");
        Console.WriteLine("2 - Gasolina");
        Console.WriteLine("3 - Diesel");
        Console.WriteLine("4 - Sair");
        opcao = int.Parse(Console.ReadLine());

        while (opcao != 4) { 
        
            if (opcao == 1) {

                alcool = alcool+ 1;
                cont = cont+ 1;
            
            }
            else if (opcao == 2)
            {
                gasolina = gasolina+ 1;
                cont= cont+ 1;
            }
            else
            {
                diesel = diesel+ 1;
                cont = diesel+ 1;
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite qual opção você deseja:");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Sair");
            opcao = int.Parse(Console.ReadLine());

        };
       
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(+cont+" clientes abasteceram,muito obrigado!");
        Console.WriteLine("- Alcool: "+alcool);
        Console.WriteLine("- Gasolina: "+gasolina);
        Console.WriteLine("- Diesel: "+diesel);
        Console.ReadLine();


    }

}