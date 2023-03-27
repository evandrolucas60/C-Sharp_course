using System;
using System.IO;
using System.Collections.Generic;

namespace DiretoryEDiretoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myFolder";

            try
            {
                //listar as pastas a partir de uma pasta informada
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (String s in folders)
                {
                    Console.WriteLine(s);
                }

                //listar os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (String f in files)
                {
                    Console.WriteLine(f);
                }

                //criar uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
