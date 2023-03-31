using System;
using System.Collections.Generic;
using ComparisonExerciceSolution.Entities;

namespace ComparisonExerciceSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            //products.Sort();//só funciona se a interface IComparable for implementada

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //função lambda

            products.Sort(comp);

            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
