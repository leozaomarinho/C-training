namespace VerificaEstoque{

    class Program { 
    
        static void Main(string[] args)
        {
            int estoqueAtual = 0,quantAdd,quantRemove,opcao = 0;

           

            while (opcao < 1) {

                Console.WriteLine("O que você deseja fazer:");
                Console.WriteLine("1 - Adicionar item ao estoque");
                Console.WriteLine("2 - Remover item do estoque");
                Console.WriteLine("3 - Ver quantidade de items em estoque");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao ==1) {

                    Console.Write("Quantos items você esta adicionando ao estoque?");
                    quantAdd = int.Parse(Console.ReadLine());

                    estoqueAtual += quantAdd;

                    Console.WriteLine("Items adicionados ao estoque");
                }

            }

           
        }
    
    }
}