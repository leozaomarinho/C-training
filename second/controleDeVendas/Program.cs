using System;

namespace controleDeVendas
{
    class Program
    {

        static void Main(string[] args)
        {

            string nomeProd;
            double precoProd;
            int quantEstoque;

            string nomeClient;
            int quantVendida;
            int formaPagamento;
            double valorPagamento;
            double totalVenda;
            double troco;

            Console.WriteLine("Digite o nome do produto: ");
            nomeProd = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            precoProd = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto que há em estoque: ");
            quantEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite as informações da venda:");
            Console.WriteLine("Digite o nome do cliente:");
            nomeClient = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto a ser vendida: ");
            quantVendida = int.Parse(Console.ReadLine());

            if (quantVendida <= quantEstoque)
            {

                quantEstoque -= quantVendida;

                Console.WriteLine("Digite como será a forma de pagamento? digite o número que corresponda a forma de pagamento:");
                Console.WriteLine("1 - Dinheiro");
                Console.WriteLine("0 - Cartão");

                formaPagamento = int.Parse(Console.ReadLine());

                totalVenda = precoProd * quantVendida;


                if (formaPagamento == 1)
                {
                    Console.WriteLine($"O valor da compra é de {totalVenda} R$ ,Digite o valor que utilizará para pagar:");
                    valorPagamento = double.Parse(Console.ReadLine());

                    if (valorPagamento > totalVenda)
                    {

                        troco = valorPagamento - totalVenda;

                        Console.WriteLine($"O cliente possui {troco} R$ de troco.");
                    }
                }
                else if (formaPagamento == 0)
                {
                    Console.WriteLine("O pagamento será no cartão, o cliente não possui troco!");
                }
                else {
                    Console.WriteLine("Forma de pagamento invalida! Refaça o processo.");
                }
            }
            else
            {
                Console.WriteLine("Não é possível vender uma quantidade maior do que há em estoque!");
            }
        }
    }
}
