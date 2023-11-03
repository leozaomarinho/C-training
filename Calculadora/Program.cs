using System;
using System.ComponentModel.Design;

namespace Calculadora
{

    public class Program {
        static void Main(string[] args)
        {

            Menu();


        }

        public static void Menu() { 
        
            Console.Clear();

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");

            
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    EncontrarRestoDivisao();
                    break;
                case 6:
                    CalcularPotenciacao();
                    break;
                case 0:
                    break;
                default:
                    Menu();
                    break;
            }

        }


    public static void Somar()
        {

            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma de {valor1} + {valor2} = {valor1+valor2} .");
            Console.ReadLine();

            Menu();
        }


        public static void Subtrair()
        {

            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A subtração de {valor1} - {valor2} = {valor1 - valor2} .");
            Console.ReadLine();

            Menu();


        }

        public static void Dividir()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A divisão de {valor1} / {valor2} = {valor1 / valor2} .");
            Console.ReadLine();

            Menu();


        }

        public static void Multiplicar()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A multiplicação de {valor1} * {valor2} = {valor1 * valor2} .");
            Console.ReadLine();

            Menu();

        }

        public static void EncontrarRestoDivisao()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            if (valor2 != 0)
            {
                Console.WriteLine($"O resto da divisão de {valor1} / {valor2} = {valor1 % valor2} .");
                
            }
            else
            {
                Console.WriteLine("Nâo é possível dividir por 0");
            }

            Console.ReadLine();
            Menu();

        }

        public static void CalcularPotenciacao()
        {
            double basePotenciacao, expoente;

            Console.WriteLine("Informe a base:");
            basePotenciacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente:");
            expoente = double.Parse(Console.ReadLine());

            Console.WriteLine($"{basePotenciacao} elevado a {expoente} = {Math.Pow(basePotenciacao, expoente)}");

            Console.ReadLine();
            Menu();

        }

}
}