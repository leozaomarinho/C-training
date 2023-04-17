using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeFuncionario
{
    public class FuncionarioDados
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() { 
        
            return SalarioBruto - Imposto;

        }
        public void AumentarSalario(double porcentagem) { 
        
            double ajuste = (SalarioBruto * porcentagem)/100;

        SalarioBruto = SalarioBruto+ajuste;
        
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido();
        }


    }
}
