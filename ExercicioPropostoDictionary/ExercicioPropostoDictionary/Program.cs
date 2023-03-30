using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioPropostoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            String path = Console.ReadLine();
            String targetPath = @"C:\temp\myFolder\out";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        String[] line = sr.ReadLine().Split(',');
                        String name = line[0];
                        int votes = int.Parse(line[1]);

                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += votes;
                        }
                        else
                        {
                            dictionary[name] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item);
                    }                  
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
