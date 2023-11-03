using System;

using System;

using SomaMedia.Entities;

namespace SomaMedia
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Nums> nums = new List<Nums>();

            double soma = 0;

            Console.WriteLine("Quantos valores o usuário deseja informar? ");
            int quant = int.Parse(Console.ReadLine());
            if (quant >= 3)
            {
                for (int i = 1; i <= quant; i++)
                {


                    Console.Write($"digite o {i} valor: ");
                    double value = double.Parse(Console.ReadLine());

                    nums.Add(new Nums(value));

                    soma += value;


                }

                double media = soma / nums.Count;


                Console.WriteLine($"A soma dos valores é {soma} e a média é {media}");
            }

            else
            {
                Console.WriteLine("Não é possível realizar a operação com menos de 3 valores, refaça o processo!");
            }
        }




    }
}