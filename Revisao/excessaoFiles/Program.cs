using System;
namespace Excessao
{
    class Program
    {
        static void Main(string[] args)
        {
            //armazenando o arquivo original e copia em variavel para passar como parametro
            string sourcePath = @"C:\Users\leozao\Downloads\file1.txt";
            string targetPath = @"C:\Users\leozao\Downloads\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                //mandando ler o arquivo que esta no caminho da variavel source path e salvando em um array

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    Console.WriteLine(line.Length);
                }

            }
            catch(IOException e){
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}