using System;
using System.Globalization;

namespace aprovacao { 

    class Program
    {

        static void Main(string[] args)
        {

            double nota1,nota2;
            double notaFinal;

            Console.WriteLine("Digite a nota do primeiro semestre:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota do segundo semestre:");
            nota2 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = (nota1 + nota2);

            if (notaFinal >= 60)
            {
                Console.WriteLine("Nota final = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado! parabens.");


            }
            else {
                Console.WriteLine("Aluno Reprovado!!");
                Console.WriteLine("Nota final = " +notaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }






        }


    }

}