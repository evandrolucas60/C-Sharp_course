using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEmployeeClass.Entities
{
    class OutsourcedEmployee : Employee
    {
        //Variável de Instância
        public double AdditionalCharge { get; set; }

        //Construtores
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //métodos
        public sealed override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}
