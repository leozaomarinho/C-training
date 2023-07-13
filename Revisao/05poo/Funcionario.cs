using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05poo
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {

           double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = SalarioBruto * porcentagem;

            SalarioBruto += aumento;
        }

        public override string ToString()
        {
            return $"Dados atualizados: {Nome}, $ {SalarioLiquido()}";
        }
    }
}
