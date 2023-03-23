using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolymorphismExerciceClassProduct.Entities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag()
        {
            return Name 
                + " $"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
