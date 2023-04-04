using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using ExercicioLINQResolvido.Entities;

namespace ExercicioLINQResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            String path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    String[] fields = sr.ReadLine().Split(',');
                    String name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
