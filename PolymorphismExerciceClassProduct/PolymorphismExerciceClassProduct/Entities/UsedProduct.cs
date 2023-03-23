using System;
using System.Globalization;

namespace PolymorphismExerciceClassProduct.Entities
{
    class UsedProduct : Product
    {
        DateTime ManufactureDate = new DateTime();

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufatureDate)
            : base(name, price)
        {
            ManufactureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return
                Name
                + "(used) "
                + " $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufactured date:  "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
