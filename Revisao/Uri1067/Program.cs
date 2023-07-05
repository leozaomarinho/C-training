using System;

class Uri {
    static void Main(string[] args)
    {
        int x;
        
        int i = 0;

        x = int.Parse(Console.ReadLine());


        do
        {
            int impar = 0;

            if (i % 2 != 0)
            {
                impar = i;

                Console.WriteLine(impar);

            }
      
            i++;

        }
        while (i < x);
    }
}