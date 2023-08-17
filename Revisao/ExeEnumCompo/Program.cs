using System;
using ExeEnumCompo.Entities;
using ExeEnumCompo.Entities.Enums;

namespace ExeEnumCompo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----- Enter cliente Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime Bdate = DateTime.Parse(Console.ReadLine());

            //instanciando o objeto cliente
            Client client = new Client(name,email,Bdate);

            Console.WriteLine("----- Enter order Data: ");
            Console.Write("Status :");

            //lendo o enum status
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); 

            Order order = new Order(DateTime.Now,status,client);
            Console.Write("How many items to this order? ");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();

                Console.WriteLine($"Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


            }



        }
    }
}