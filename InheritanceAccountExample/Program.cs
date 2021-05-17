using InheritanceAccountExample.Entities;
using System;
using System.Globalization;

namespace InheritanceAccountExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(100, "Erikson", 500.00);

            //UPCASTING
            Account acc2= new BusinessAccount(102, "José", 0.00, 500.00);
            Account acc3 = new SavingAccount(103, "Ribeiro", 500.00, 0.10);

            //DOWNCASTING

            BusinessAccount bcc1 = (BusinessAccount)acc2;
            // OR
            BusinessAccount bbc2 = acc2 as BusinessAccount;

            if (acc3 is BusinessAccount)
            {
                // ERROR  BusinessAccount bbc3 = acc3 as BusinessAccount; -- acc3 is a SavingAccount
                BusinessAccount bbc3 = acc3 as BusinessAccount;
                bbc3.Load(500.00);
            }

            if (acc3 is SavingAccount)
            {
                SavingAccount scc1 = acc3 as SavingAccount;
                //scc1.UpdateBalance(500.00);
                Console.WriteLine("Updated!");
            }

            Console.WriteLine($"{acc1.Balance}");
            Console.WriteLine($"{acc3.Balance}");

            acc1.Withdaw(10.00);
            acc3.Withdaw(10.00);

            Console.WriteLine($"{acc1.Balance}");
            Console.WriteLine($"{acc3.Balance}");

            Console.ReadLine();
        }
    }
}
