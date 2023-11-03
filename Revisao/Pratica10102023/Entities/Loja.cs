using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica10102023.Entities;

namespace Pratica10102023.Entities
{
    public class Loja
    {
        public List<Produto> Produto { get; set; }

        public Boolean Status { get; set; }

        public int Quantidade { get; set; }

        public string NomeLoja { get; set; }


        public Loja() { 
        
        }

        public Loja(List<Produto> produto, Boolean status,int quantidade) {
            
            this.Produto = produto;
            this.Status = status;
            this.Quantidade = quantidade;
        
        }


        public override string ToString()
        
        {
         return   $"A loja {NomeLoja} esta {Status} !";
        }
       



    }
}
