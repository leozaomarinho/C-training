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

            //operador de coalescência nula

            double? z = null;

            double a = z ?? 0.0;
            //a variavel a recebe o valor de Z, entretando as ?? coloca a condicional que se o valor z for null a variavel A recebe o valor 0 ( o valor que estiver a direita da ??);


        }
    }
}