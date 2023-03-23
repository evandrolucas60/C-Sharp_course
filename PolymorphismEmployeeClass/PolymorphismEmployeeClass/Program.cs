using System;
using System.Collections.Generic;
using PolymorphismEmployeeClass.Entities;
using System.Globalization;

namespace PolymorphismEmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + "- $ "
                        + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
