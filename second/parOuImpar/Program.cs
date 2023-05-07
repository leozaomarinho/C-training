namespace ParOuImpar
{

    class Program
    {
        public static void Main(string[] args)
        {
            double a = 3;
            double b = 4;


            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} é par!");
            }
            else
            {
                Console.WriteLine($"{a} é impar!");
            }

            if (b % 2 == 0)
            {
                Console.WriteLine($"{b} é par!");
            }
            else
            {
                Console.WriteLine($"{b} é impar!");
            }
        }
    }
}
