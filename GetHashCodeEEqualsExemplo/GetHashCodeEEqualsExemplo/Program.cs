using System;
using GetHashCodeEEqualsExemplo.Entities;

namespace GetHashCodeEEqualsExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client {Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client {Name = "Lucas", Email = "Lucas@yahoo.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);//compara a referecia de memória
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
