using CompositionExercise.Entities;
using CompositionExercise.Entities.Enums;
using System;
using System.Globalization;

namespace CompositionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter Worker Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Worker Level (Junior/MidLevel/Senior): ");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level);
            Console.Write("Enter Worker Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} Contract Data: ");
                Console.Write("Contract Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Durantion (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
                Console.WriteLine("-------------------------------------------------------------");
            }

            Console.WriteLine("\nEnter month and year to calcule income(MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year  = int.Parse(monthYear.Substring(3));

            Console.WriteLine($"\nName: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthYear}: {worker.Income(year,month):F2}");

            Console.ReadKey();
        }
    }
}
