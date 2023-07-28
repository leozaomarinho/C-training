using vetEmObjetos;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Quantas pessoas você deseja cadastrar? ");
            n = int.Parse(Console.ReadLine());

            Pessoa[] pessoa = new Pessoa[n];


            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome da pessoa: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade da pessoa: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite o email da pessoa: ");
                string email = Console.ReadLine();

                pessoa[i] = new Pessoa(nome, idade, email);

                Console.WriteLine("----------------------------------------------------------------");
                

            }

            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine("1 - Listar as pessoas cadastradas.");
            Console.WriteLine("0 - Sair.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Você escolheu sair!");
                    break;
                
                case 1:
                    Console.WriteLine("Você escolheu listar pessoas:");
                    Console.WriteLine("--------------------- Pessoas -----------------");
                    ListarPessoas(pessoa);
                    
                    break;

            }




        }
        public static void ListarPessoas(Pessoa[] pessoas)
        {

            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }

    }
}