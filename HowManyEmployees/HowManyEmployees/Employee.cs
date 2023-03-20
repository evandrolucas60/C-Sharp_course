using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyEmployees {
    internal class Employee {

        public int Id { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double value) {
            this.Salary += Salary * value/100.0;
        }

        public override string ToString() {
            return Id 
                + ", "
                + Name
                + ", "   
                + Salary;
        }
    }
}
