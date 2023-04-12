using System;

namespace UsandoParse
{
    class Program
    {

        static void Main(string[] args)
        {

            double a = 5.8;
            float b;
            int c;

            //a = b;

            b = (float)a;
            c = (int)(float)b;

            Console.WriteLine(b + c);
        }
    }
}
