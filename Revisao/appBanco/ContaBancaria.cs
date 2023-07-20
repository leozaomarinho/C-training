using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco
{
    internal class ContaBancaria
    {
        private int NumConta;
        private string NomeTitular;
        private double SaldoInicial;

       
        public void Deposito(double valor)
        {
            this.SaldoInicial += valor;
        }

        public void Saque(double valor)
        {

            this.SaldoInicial -= valor;

        }


        public override string ToString()
        {
            return $"Dados Atualizados:\nConta {NumConta}, Titular: {NomeTitular}, Saldo: {SaldoInicial}";
        }

    }

    }

