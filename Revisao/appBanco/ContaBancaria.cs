﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco
{
    internal class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoInicial { get; private set; }

        public ContaBancaria(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            SaldoInicial = 0;
        }

        public ContaBancaria(int numConta, string nomeTitular, double saldoInicial) :this(numConta,nomeTitular){

            SaldoInicial = saldoInicial;

        }

    public void Deposito(double valor)
    {
        this.SaldoInicial += valor;
    }

    public void Saque(double valor)
    {

            this.SaldoInicial = SaldoInicial -5;
              this.SaldoInicial  -= valor;

    }


    public override string ToString()
    {
        return $"Dados Atualizados:\nConta {NumConta}, Titular: {NomeTitular}, Saldo: {SaldoInicial.ToString("F2",CultureInfo.InvariantCulture)}";
    }

}

    }

