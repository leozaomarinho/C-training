using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06poo
{
    internal class Aluno
    {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public void Aprovacao()
        {
            double soma = N1 + N2 + N3;

            if (soma >=60)
            {
                Console.WriteLine($"Notal Final: {soma}");
                Console.WriteLine("APROVADO");
            }
            else { 
            
                double pontos = 60 - soma;
                Console.WriteLine($"Notal Final: {pontos}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {pontos.ToString("F2",CultureInfo.InvariantCulture)} PONTOS");

            }
        }

    }
}
