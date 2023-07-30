
namespace matrizProd
{
    internal class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }

        public Produto(string nome, double preco, int quant)
        {

            this.Nome = nome;
            this.Preco = preco;
            this.Quant = quant;
        }

        
    }
}
