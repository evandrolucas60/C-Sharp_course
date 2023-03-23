using System;
using System.Collections.Generic;
using PolymorphismExerciceClassProduct.Entities;

namespace PolymorphismExerciceClassProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i + 1} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, dateTime));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product obj in list)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
