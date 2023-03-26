using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String sourcePath = @"C:\temp\file1.txt";
            String targetPath = @"C:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                String[] lines = File.ReadAllLines(sourcePath);
                foreach (String line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}