using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using ExercicioFixacaoLINQ.Entities;

namespace ExercicioFixacaoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            String path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        String[] fields = sr.ReadLine().Split(',');
                        String name = fields[0];
                        String email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }

                    var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                    var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (String email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(e.Message);
            }

           
        }
    }
}
