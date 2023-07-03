using System;

class Program
{
    static void Main(string[] args)
    {
        int entrada, resultado;

        Console.WriteLine("Digite o valor que você deseja ver a taboada:");
        entrada = int.Parse(Console.ReadLine());

        for(int i = 1; i<=10;i++)
        {
            resultado = i * entrada;
            Console.WriteLine($"{i} x {entrada} = {resultado}");

        }

        Console.WriteLine("Taboada encerrada.");
    }
}