using System;
using System.Globalization;

class URI {

    static void Main(string[] args)
    {
        int golsInter = 0,golsGremio=0, vit=0, emp = 0, derr=0, inter= 0, gremio=0,novoGrenal,numJogos=0,gols=0;
        string mVenc;

        Console.WriteLine("Novo grenal (1-Sim 2-Não)");
        novoGrenal = int.Parse(Console.ReadLine());

        while (novoGrenal == 1) {

            numJogos++;
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Quem venceu o jogo: 1-Inter 2-Gremio 3-Empate");
            vit = int.Parse(Console.ReadLine());
            if (vit == 1)
            {
                inter += 1;

            }
            else if (vit == 2)
            {
                gremio += 1;
            }
            else { 
            emp += 1;
            
            }
            Console.WriteLine("Quantos gols o inter marcou:");
            gols=int.Parse(Console.ReadLine());
            if (golsInter > 0)
            {
                golsInter += gols;
            }
            else {
                Console.WriteLine("Quantos gols o gremio marcou");
                gols= int.Parse(Console.ReadLine());
                golsGremio += gols;
                Console.WriteLine("----------------------------------------------------------------------------------------------------");

            };

            Console.WriteLine("Novo grenal (1-Sim 2-Não)");
            novoGrenal = int.Parse(Console.ReadLine());

            

        }

        if (inter > gremio && inter>emp)
        {

            mVenc = $"Inter venceu com {inter} vitorias";

        }
        else if (gremio > inter && gremio>emp)
        {
            mVenc = $"Gremio venceu com {gremio} vitorias";
        }
        else
        {

            mVenc = "Não houve maior vencedor, pois o número de vitorias esta empatado.";
        }


        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine("| "+numJogos+" GRENAIS fizeram parte da estatistica.");
        Console.WriteLine("| O numero de vitorias do inter foi de: "+inter);
        Console.WriteLine("| O numero de vitorias do gremio foi de: "+gremio);
        Console.WriteLine("| O numero de empates foi de : "+emp);
        Console.WriteLine("| quem venceu o maior número de GRENAIS: "+mVenc);
        Console.WriteLine("----------------------------------------------------------------------------------------------------");

    }

}