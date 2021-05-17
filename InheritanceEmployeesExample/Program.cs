using InheritanceEmployeesExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InheritanceEmployeesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("##########################################################");
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsource (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                    employee.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in employee)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment():f2}");
            }

            Console.ReadKey();
        }
    }
}
