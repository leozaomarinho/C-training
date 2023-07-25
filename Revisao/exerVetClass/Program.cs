using exerVetClass;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quartos = new int[10];
            

            Console.Write("Quantos estudantes vão alugar quartos:");
            int n = int.Parse(Console.ReadLine());

            Cliente[] clientes = new Cliente[n];

            for(int i = 0; i < n;i++) {

                int numQuarto = 0;
                string nome;
                string email;


                    Console.Write("Digite o nome do cliente: ");
                     nome = Console.ReadLine();
                    Console.Write("Digite o email do cliente: ");
                    email = Console.ReadLine();



                do
                {
                    Console.Write("Escolha um quarto de 0 a 9:");


                    if (quartos[i] == 0)
                    {
                        numQuarto = int.Parse(Console.ReadLine());
                        quartos[i] = 1;

                    }
                    else if (quartos[i] == 1)
                    {
                        Console.WriteLine($"O quarto {quartos[i]} já esta ocupado!");
                        Console.WriteLine("Quartos disponíveis: ");
                        
                        for(int j = 0; j < quartos.Length; j++)
                        {
                            if (quartos[j] == 0)
                            {
                                Console.Write($" {quartos[j]} ");
                            }
                        }

                    }
                }
                while (quartos[i]!=0);

                

                clientes[i] = new Cliente { Nome = nome, Email = email, NumQuarto = numQuarto};


                


            }

            for (int i = 0; i < quartos.Length; i++)
            {

                if (clientes[i].NumQuarto < clientes[i + 1].NumQuarto || quartos[i]==1)
                {
                    Console.WriteLine("Quartos alugados: ");
                    Console.WriteLine($"{clientes[i].NumQuarto} : {clientes[i].Nome}, {clientes[i].Email}");
                }

            }


        }
        }
    }
