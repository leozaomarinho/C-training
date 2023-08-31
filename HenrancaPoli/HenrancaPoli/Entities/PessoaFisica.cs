using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
    internal class PessoaFisica : Contribuintes
    {

        public double HealthExpenditures { get; set; }

        public PessoaFisica(string name,double anualIncome,double healthExp)
        :base(name,anualIncome){ 
        
        }

        public override double Tax()
        {
            ;
        }


    }
}
