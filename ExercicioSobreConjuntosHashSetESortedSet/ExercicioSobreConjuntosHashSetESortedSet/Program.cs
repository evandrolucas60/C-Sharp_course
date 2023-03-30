using System;
using System.Collections.Generic;
using System.IO;
using ExercicioSobreConjuntosHashSetESortedSet.Entities;

namespace ExercicioSobreConjuntosHashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>(); 

            Console.Write("Enter file full path: ");
            String path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        String[] line = sr.ReadLine().Split(' ');
                        String name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { UserName = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {

                Console.Write("An error has occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
