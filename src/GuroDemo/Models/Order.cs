using System;
using System.Collections.Generic;
using System.Linq;

namespace GuroDemo
{
    // Represents an order containing customer information and a list of order items
    internal class Order
    {
        public Customer Customer { get; }
        public DateTime CreatedAt { get; }
        private readonly List<OrderItem> _items = new List<OrderItem>();

        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

        public Order(Customer customer)
        {
            Customer = customer;
            CreatedAt = DateTime.Now;
        }

        public void AddItem(Product product, int quantity)
        {
            _items.Add(new OrderItem(product, quantity));
        }

        // Refactoring applied: Replace Temp with Query by encapsulating total calculation in a method
        public double GetTotal()
        {
            double total = _items.Sum(item => item.GetSubtotal());
            return total;
        }
    }
}
