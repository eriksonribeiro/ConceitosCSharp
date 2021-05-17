using System;
using System.Collections.Generic;

namespace OrderExercise.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * Price;
        }

        public override string ToString()
        {
            return ($"Product: {Product.Name}, Price: ${Price:f2}, Quantity: {Quantity}, Subtotal: ${SubTotal():f2}");
        }
    }
}
