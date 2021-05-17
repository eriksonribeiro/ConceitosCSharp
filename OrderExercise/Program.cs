using OrderExercise.Entities;
using OrderExercise.Entities.Enums;
using System;
using System.Globalization;

namespace OrderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY) : ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            Order order = new Order(status, client);

            Console.Write("\nHow Many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data:");
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(pName, price);

                Console.Write("Quantity: ");
                int quatity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quatity, price, product);

                order.AddItem(orderItem);

                Console.WriteLine("---------------------------------------------------------------");
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadLine();

        }
    }
}
