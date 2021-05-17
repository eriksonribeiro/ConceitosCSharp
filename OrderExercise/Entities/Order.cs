using OrderExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderExercise.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
            this.Moment = DateTime.Now;
        }

        public Order(OrderStatus status, Client client) : this ()
        {
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            this.Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            this.Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.00;

            foreach (OrderItem item in this.Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment: {Moment}");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"{Client}");
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in this.Items)
            {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine($"Total Price: ${Total():f2}");
            return sb.ToString();
        }
    }
}
