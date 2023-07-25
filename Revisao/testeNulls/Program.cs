using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("a variavel X possui valor null");
            }

            //gera um erro de excessão se for chamado a partir de um objeto nullable
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("a variavel Y possui o valor null");
                    };


        }
    }
}