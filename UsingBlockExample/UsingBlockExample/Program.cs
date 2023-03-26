using System.IO;

namespace UsingBlockExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\temp\file1.txt";


            try
            {
                //garante que os objetos serão fechados ao termino do bloco using
               
                using (StreamReader sr = File.OpenText(path))//sitax simplificada
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.Write("An Error has occurred: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}