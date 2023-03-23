using System;
using System.Collections.Generic;
using AbstractMethodsExercice.Entities;
using System.Globalization;

namespace AbstractMethodsExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine());

                    list.Add(new Indivudual(name, anualIncome, healthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer obj in list)
            {
                Console.WriteLine(obj.Name
                                  + ": $"
                                  + obj.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0;
            foreach (TaxPayer obj in list)
            {
                sum += obj.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum);

        }
    }
}
