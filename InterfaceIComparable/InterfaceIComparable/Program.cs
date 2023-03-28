using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\temp\myFolder\file3.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<String> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort(); //ordenar a lista
                    foreach (String str in list)
                    {
                        Console.WriteLine(str);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
