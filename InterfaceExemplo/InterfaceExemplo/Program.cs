using System;
using System.Globalization;
using InterfaceExemplo.Entities;

namespace InterfaceExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            String model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);

            Vehicle vehicle = new Vehicle(model);
            CarRental carRental = new CarRental(start, finish, vehicle);
        }
    }
}
