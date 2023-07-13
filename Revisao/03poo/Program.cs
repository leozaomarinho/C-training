using _03poo;

namespace program
{

    class Program
    {
        static void Main(string[] args)
        {
            Produto TV;

            TV = new Produto();

            Console.WriteLine("Adicionando produtos ao estoque:");

            Console.WriteLine("Digite o nome do produto:");
            TV.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            TV.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            TV.Quantidade = int.Parse(Console.ReadLine());


            int options = 0;

            do
            {
                Console.WriteLine("O que você deseja fazer:");
                Console.WriteLine(" 0 - Ver valor total em estoque");
                Console.WriteLine(" 1 - Adicionar produtos ao estoque");
                Console.WriteLine(" 2 - Remover produtos do estoque");
                Console.WriteLine(" 3 - Ver quantidade de produtos em estoque");
                Console.WriteLine(" 4 - Sair");

                options = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------------------------");
                switch (options)
                {
                    case 0:

                        Console.WriteLine($"O valor total dos produtos em estoque é de : {TV.ValorTotalEmEstoque()}");
                        Console.WriteLine("----------------------------------------------------------");

                        break;

                    case 1:

                        Console.WriteLine("Quantos produtos desejar adicionar ao estoque:");
                        int quantAdd = int.Parse(Console.ReadLine());
                        TV.AdicionarProdutos(quantAdd);
                        Console.WriteLine("----------------------------------------------------------");

                        break;

                    case 2:

                        Console.WriteLine("Quantos produtos deseja remover do estoque:");
                        int quantRem = int.Parse(Console.ReadLine());
                        TV.RemoverProdutos(quantRem);
                        Console.WriteLine("----------------------------------------------------------");

                        break;

                    case 3:
                        TV.VerEstoque();

                        Console.WriteLine("----------------------------------------------------------");

                        break;

                    case 4:

                        Console.WriteLine("Você escolheu sair! Até breve");
                        Console.WriteLine("----------------------------------------------------------");

                        break;
                }

            } while (options != 4);
        }
    }
}