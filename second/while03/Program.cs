namespace While3
{

    class Program
    {

        static void Main(string[] args)
        {
            string nome, cpf, marca, modelo, placa;
            double valMinuto, valTotal;
            int menu, idCliente, clienteIdVeic;

            for (int i = 0; i != 0; i++)
            {

                Console.WriteLine("O que você deseja fazer?:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Cadastrar Veiculo");
                Console.WriteLine("3 - Registrar entrada");
                Console.WriteLine("4 - Registrar saida");
                Console.WriteLine("0 - Sair");

                if (i == 1)
                {



                    Console.WriteLine("Digite o nome do cliente:");
                    nome = Console.ReadLine();

                    idCliente = i;

                    Console.WriteLine("Digite o CPF do cliente:");
                    cpf = Console.ReadLine();

                    Console.WriteLine("Cliente cadastrado com sucesso!");

                    Console.WriteLine($"{nome} cpf {cpf} id {idCliente}");
                }

                else if (i == 2)
                {
                    clienteIdVeic = idCliente;
                    Console.WriteLine();

                }


            }



        }

    }
}

