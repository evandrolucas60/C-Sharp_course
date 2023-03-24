using System;
using System.IO;

namespace BlocoFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\evandro.silva\source\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
