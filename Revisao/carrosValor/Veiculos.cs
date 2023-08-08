using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosValor
{
    internal class Veiculos

    {
        public string Modelo { get; set; }
        public double Valor { get; set; }

        public string Cor { get; set; }

        public int Ano { get; set; }

        public Veiculos(string model,double valor, string cor,int ano) {
        
        this.Modelo = model;
            this.Valor = valor;
            this.Cor = cor;
            this.Ano = ano;
        
        }

        public override string ToString()
        {
            return $"Modelo : {Modelo} | Valor : {Valor} | Ano : {Ano} | Cor : {Cor}";
        }

    }
}
