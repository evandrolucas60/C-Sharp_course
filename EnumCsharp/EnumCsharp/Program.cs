using EnumCsharp.Entities;
using EnumCsharp.Entities.Enums;
using System;

namespace EnumCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            /*
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
            */
        }
    }
}
