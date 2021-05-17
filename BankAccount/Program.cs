using System;
using System.Globalization;

namespace ExerciseBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Enter with a Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter with a Owner Name: ");
            string ownerName = Console.ReadLine();
            Console.Write("Will be a initial deposit (y/n)? ");
            char initialDeposit = char.Parse(Console.ReadLine().ToUpper());

            if (initialDeposit == 'Y')
            {
                Console.Write("Enter with an initial deposit: ");
                double initialAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(accountNumber, ownerName, initialAmount);
            }
            else
                account = new BankAccount(accountNumber, ownerName);

            Console.WriteLine($"\nAccount Data:\n{account}\n");

            Console.Write("Enter with a deposit: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"\nAccount Update Data:\n{account}\n");

            Console.Write("Enter with an draw: ");
            account.Draw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"\nAccount Update Data:\n{account}\n");

            Console.ReadKey();

        }
    }
}
