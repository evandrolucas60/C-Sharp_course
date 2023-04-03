using System;
namespace DelegateFunc.Entities
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
