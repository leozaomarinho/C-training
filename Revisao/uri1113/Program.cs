﻿using System;

class URI {

    static void Main(string[] args)
    {

        int x,y;
        string[] vet = Console.ReadLine().Split(' ');

        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        while (x != y) {


            if (x > y) {
                Console.WriteLine("Decrescente");
            }
            else if (x < y)
            {
                Console.WriteLine("Crescente");
            }

             vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);


        }

    }

}