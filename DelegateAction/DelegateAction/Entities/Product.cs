using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAction.Entities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double prince)
        {
            Name = name;
            Price = prince;
        }

        public override string ToString()
        {
            return Name + ", " + Price;
        }
    }
}
