using System;
using System.Collections.Generic;
using System.Linq;

namespace GuroDemo
{
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

        public double GetTotal()
        {
            double total = _items.Sum(item => item.GetSubtotal());
            return total;
        }

        public List<OrderItem> RemoveProduct(OrderItem orderItem)
        {
            if (IsPresent(orderItem) && orderItem.Quantity <=1)
            {
                _items.Remove(orderItem);
            }
            else { orderItem.Quantity -= 1; }
            return _items;
        } 

        private bool IsPresent(OrderItem orderItem)
        {
            foreach (OrderItem item in _items)
            {
                if(item.Product.GetName().Equals(orderItem.Product.GetName()))
                    return true;
            }
            return false;
        }
    }
}
