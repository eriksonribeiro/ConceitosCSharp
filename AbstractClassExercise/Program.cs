using AbstractClassExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payerList = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("********************************************");
                Console.WriteLine($"Tax payer #{1} data:");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());

                    payerList.Add(new Company(name, anualIncome, employeeNumber));
                }
                else if (type == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    payerList.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                    Console.WriteLine("Type of Payers dont find!");
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0;

            foreach (Payer payer in payerList)
            {
                totalTaxes += payer.TaxesCalculation();
                Console.WriteLine(payer);
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes:f2}");

            Console.ReadLine();
        }
    }
}
