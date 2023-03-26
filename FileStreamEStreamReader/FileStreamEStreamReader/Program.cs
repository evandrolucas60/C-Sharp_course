using System.IO;
namespace FileStreamEStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                String line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}