using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodsExercice.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        abstract public double Tax();
    }
}
