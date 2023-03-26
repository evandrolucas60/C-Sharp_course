using TryCatchExercice.Entities;
using TryCatchExercice.Entities.Exception;
using System.Globalization;

namespace TryCatchExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            String holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number,holder,initialBalance,withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
            account.Withdraw(amount);
            Console.WriteLine("New balance: " + account.Balance);

            }
            catch (DomainException e)
            {

                Console.WriteLine("Error message: " + e.Message);
            }


        }
    }
}