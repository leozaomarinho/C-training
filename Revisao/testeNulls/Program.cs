using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x= null;
            double? y= 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

        }
    }
}