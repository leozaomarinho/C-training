namespace Atividade01
{
    class Program
    {

        static void Main(string[] args)
        {

            string nomeProd;
            double valorProd;
            int quantProd;
            double valorTotal;
            double pagamento;
            double troco;

            string nomeClient;
            string endereco;

            Console.WriteLine("Digite o nome do produto a ser cadastrado: ");
            nomeProd = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            valorProd = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade do produto que o cliente deseja:");
            quantProd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente:");
            nomeClient = Console.ReadLine();

            Console.WriteLine("Digite o endereço do cliente: ");
            endereco = Console.ReadLine();

            valorTotal = (double)valorProd * quantProd;

            Console.WriteLine($"O cliente {nomeClient} escolheu {quantProd} unidades do produto {nomeProd} e deve pagar {valorTotal}.");
            Console.WriteLine("Efetue o pagamento: ");
            pagamento = double.Parse(Console.ReadLine());

            if (pagamento > valorTotal)
            {
                troco = pagamento - valorTotal;

                Console.WriteLine($"Você possui troco, no valor de {troco}, obrigaod e volte sempre!.");
            }
            else
            {
                Console.WriteLine("Você não possui troco, obrigado e volte sempre!");
            }




        }
    }
}