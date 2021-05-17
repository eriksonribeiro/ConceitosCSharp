using BankAccountExceptions.Entities;
using BankAccountExceptions.Entities.Domain;
using System;
using System.Globalization;


namespace BankAccountExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance : ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, limit);

                Console.WriteLine($"\n{account}");

                Console.WriteLine("\n******************************************");
                Console.WriteLine("Enter amount for withdraw:");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine($"\n{account}");

            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Invalid: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error not expected: {e.Message}");
            }


            Console.ReadKey();
        }
    }
}
