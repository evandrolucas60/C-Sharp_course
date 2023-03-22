using System;
using HerancaAccountExercice.Entities;
namespace HerancaAccountExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(1008, "Alex Green", 500.00);

            Console.WriteLine(ac.Balance);
        }
    }
}
