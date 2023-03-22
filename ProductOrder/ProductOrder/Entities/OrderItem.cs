using System;
using System.Globalization;

namespace ProductOrder.Entities
{
    class OrderItem
    {
        //Variáveis de instância
        public int Quantity { get; set; }
        public double Price { get; set; }

        //composição 
        public Product Product { get; set; }

        public OrderItem()
        {

        }    
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
           return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " 
                + ", "
                + Quantity.ToString("F2", CultureInfo.InvariantCulture)
                + " Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }   
    }
}
