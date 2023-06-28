using System;
using System.Globalization;

class Exercicio {

    static void Main(string[] args)
    {
        double idade,media, soma = 0;
        int cont = 0;

        Console.WriteLine("Digite a idade:");
        idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (idade >= 0)
        {
            
                soma+= idade;
                cont++;
                idade = double.Parse(Console.ReadLine());
                
            
           
        }
        if (cont == 0)
        {
            Console.WriteLine("Impossivel calcular!");
        }
        else {
            media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }

        
        Console.ReadLine();
    }

}