using System;
using upcasting.Entities;

namespace upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Alex", 0.0);

            BusinessAccount bAcc = new BusinessAccount(1002,"Maria", 0.0,500.0);

            Account acc1 = bAcc;
            //a variavel do tipo account ela recebe naturalmente um objeto de qualquer subclasse dela, isso é chamado de upcasting
        }
    }
}