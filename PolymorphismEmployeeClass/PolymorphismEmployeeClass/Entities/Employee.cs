using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEmployeeClass.Entities
{
    class Employee
    {
        //Variáveis de instância
        public String Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Construtores
        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //métodos
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }



    }
}
