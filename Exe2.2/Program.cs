namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string pass = "2002";

            Console.WriteLine("Digite a senha correta para ter acesso ao sistema:");
            string passw = Console.ReadLine();

            while (passw != pass)
            {
                if (passw != pass)
                {
                    Console.WriteLine("Senha invalida!");
                    Console.WriteLine("Digite a senha correta para ter acesso ao sistema:");
                    passw = Console.ReadLine();

                }



            }


            pass.GetHashCode();

            pass.GetHashCode().Equals(passw);

            Console.WriteLine("Acesso Permitido!");




        }
    }
}