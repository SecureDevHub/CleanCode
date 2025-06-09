using GuroDemo.Command;
using GuroDemo.Decoration;
using GuroDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuroDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerBuilder customerBuilder = new CustomerBuilder();
            Customer customer = customerBuilder.WithNameFromConsole().WithEmailFromConsole().WithTypeFromConsole().Build();
            Order order = new Order(customer);
            OrderManager orderManager = new OrderManager();

            List<Product> products = new List<Product>
            {
                new BaseProduct("Mouse", 25.99),
                new BaseProduct("Keyboard", 45.50),
                new BaseProduct("Monitor", 150.00),
            };

            ProductSelector selector = new ProductSelector(products);

            orderManager.Run(order, selector);
        }
    }
}
