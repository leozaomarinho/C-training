using ProdPOO.Entities;
using System;
using System.Globalization;

namespace prod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++) {

                Console.Write($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i) ?");
                char p = Char.Parse(Console.ReadLine());

                if (p == 'c')
                {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(name,price));
                }
                else if (p == 'u') {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double customsF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price,customsF));

                }
                

               
            }
        }
    }
}