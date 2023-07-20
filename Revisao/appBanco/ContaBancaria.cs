﻿using System;
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

        public void CriarConta(int numConta,string NomeTitular,double SaldoInicial)
        {

            if (NumConta <4)
            {
                this.NumConta = numConta;


                if (SaldoInicial > 0)
                {
                    this.SaldoInicial = SaldoInicial;
                }
                else
                {
                    this.SaldoInicial = 0;
                }


            }
            else
            {
                Console.WriteLine("A conta deve possuir 4 digitos! Refaça o processo");
                break;
            }

            
            this.SaldoInicial = SaldoInicial;

        }

    }
}
