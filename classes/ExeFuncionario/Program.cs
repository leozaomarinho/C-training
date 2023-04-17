using ExeFuncionario;
using System.Globalization;


namespace DadosFuncionario
{
    class Program
    {


        static void Main(string[] args) { 
        
            FuncionarioDados func = new FuncionarioDados();

            Console.WriteLine("Dados do funcionario:");
            Console.Write("Nome:");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionario:{func}");

            Console.Write("Digite a porcentagem para aumentar o salario:");
            double aumento = double.Parse(Console.ReadLine());

            func.AumentarSalario(aumento);

            Console.WriteLine($"dados Atualizados:{func}");


        }
    }
}