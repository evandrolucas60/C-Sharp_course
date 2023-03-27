using System;
using System.IO;

namespace StreamWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\evandro.silva\source\data.txt";
            string targetPath = @"C:\Users\evandro.silva\source\data2.txt";

            try
            {
                String[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw  = File.AppendText(targetPath))
                {
                    foreach (String line in lines)
                    {
                        //cria o arquivo data2, se ele não existir.
                        //Em seguida rescreve o texto de sourcePath 
                        //em uppercase.
                        sw.WriteLine(line.ToUpper()); 
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
