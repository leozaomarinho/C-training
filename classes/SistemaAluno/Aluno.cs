using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaAluno
{
    public class Aluno
    {
        public string Nome;

        public double NotaT1;
        public double NotaT2;
        public double NotaT3;
        public double NotaFinal;

        public double calculaNota()
        {

            NotaFinal = NotaT1 + NotaT2 + NotaT3;

            return NotaFinal;
        }

        public bool Aprovado()
        {
            if (NotaFinal > 60)
                {
                    return true;
                }
            else {
                return false;
                }
            }

        public double pontosRestantes()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - calculaNota();
            }

        }


    }
}
