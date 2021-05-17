using InheritanceProductExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceProductExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'c')
                    product.Add(new Product(name, price));
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customFee));
                }
                else
                    Console.WriteLine("Product type dont find!");
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product prod in product)
            {
                Console.WriteLine($"{prod.priceTag()}");
            }

            Console.ReadKey();

        }
    }
}
