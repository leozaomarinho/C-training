using System;
using System.Globalization;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {

        int N;
        double soma = 0.0, media=0.0;
        string[] vet;
        double[] vals;

       

        Console.WriteLine("Digite qual será a quantidade de elementos do vetor:");
        N=int.Parse(Console.ReadLine());

        vals = new double[N];

        Console.WriteLine("Digite os valores do vetor:");
        vet = Console.ReadLine().Split(' ');

        for(int i = 0; i < N; i++)
        {
            vals[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);

            soma+= (double) vals[i];

            media = soma / N;

            Console.Write(vals[i].ToString("F2",CultureInfo.InvariantCulture));
            
        }
        Console.WriteLine('\n'+soma.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));






    }
}