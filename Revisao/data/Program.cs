using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine($"Data atual : {d1}");

            DateTime d2 = new DateTime(2023, 08, 05, 11, 30,00);
            Console.WriteLine($"Data com horario setado: {d2}");

            DateTime d3 = DateTime.Parse("05/08/1998 13:50:58");
            Console.WriteLine($"Data com horario BR {d3}");



            Console.WriteLine(d2.ToLongDateString());
            Console.WriteLine(d2.ToLongTimeString());
            Console.WriteLine(d3.ToShortDateString());
        }
    }
}