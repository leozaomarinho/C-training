using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Globalization;

namespace prodEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEstoque()
        {

            return Preco * Quant;

        }
        public void AdicionarProdutos(int quant)
        {

            Quant += quant;

        }
        public void RemoverProdutos(int quant)
        {
            Quant -= quant;

        }
        public override string ToString()
        {
            return Nome+", $"+Preco.ToString("F2",CultureInfo.InvariantCulture)+","+Quant+" unidades, total: $" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
