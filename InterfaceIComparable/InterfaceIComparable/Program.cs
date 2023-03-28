using System;
using System.Collections.Generic;
using System.IO;
using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\temp\myFolder\file4.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //ordenar a lista
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
