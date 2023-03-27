using System;
using System.IO;
using System.Globalization;
using FilesExercicioFixacao.Entities;


namespace FilesExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            String sourceFilePath = Console.ReadLine();

            try
            {
                String[] lines = File.ReadAllLines(sourceFilePath);

                String sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                String targetFolderPath = sourceFolderPath + @"\out";
                String targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) 
                {
                    foreach (String line in lines)
                    {
                        String[] fields = line.Split(',');
                        String name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);
                        sw.WriteLine(prod.Name + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: ");
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
