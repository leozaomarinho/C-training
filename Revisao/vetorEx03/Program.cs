using System;
using System.Globalization;

class Program {
    static void Main(string[] args)
    {
        int N,i=0;

        string[] nome;
        int[] idade;
        double[] altura;
        double media = 0,menor=0;

        

        Console.WriteLine("Digite o valor de N:");
        N = int.Parse(Console.ReadLine());

        nome = new string[N];
        idade = new int[N];
        altura = new double[N];



        do
        {
            Console.WriteLine("Digite o nome(apenas o primeiro nome), idade e altura da pessoa:");
            string[] s = Console.ReadLine().Split(' ');

            nome[i] = s[i];
            idade[i] = int.Parse(s[i+1]);
            altura[i] = double.Parse(s[i + 2], CultureInfo.InvariantCulture);

            if (idade[i] < 16)
            {
                menor++;
            }
           

            media+=(double)idade[i];

            i++;

        } while (i < N);

        media = media / N;

        menor=menor *N/ 100;

        Console.WriteLine(menor.ToString("F2",CultureInfo.InvariantCulture));

        Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));


    }
}
