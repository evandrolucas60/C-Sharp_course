using System;
using System.Globalization;

namespace InterfaceIComparable.Entities
{
    class Employee : IComparable
    {
        public String Name { get; set; }
        public double Salary { get; set; }

        public Employee(String csvEmployee)
        {
            String[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);//compara por nome
            //return Salary.CompareTo(other.Salary); //compara por salário
        }
    }
}
