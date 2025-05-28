using System;
using System.Collections.Generic;
using System.Linq;

namespace GuroDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new CustomerBuilder()
                                .WithNameFromConsole()
                                .WithEmailFromConsole()
                                .WithTypeFromConsole()
                                .Build();

            var order = new Order(customer);

            var products = new List<Product>
            {
                new Product("Mouse", 25.99),
                new Product("Keyboard", 45.50),
                new Product("Monitor", 150.00),
            };

            ProductSelector selector = new ProductSelector(products);
            OrderSender sender = new OrderSender();

            bool continua = true;
            while (continua)
            {
                selector.ShowAvailableProducts();
                Product p = selector.GetProduct();
                int q = selector.GetProductQuantity(p);
                order.AddItem(p, q);

                double total = order.Items.Sum(item => item.Product.Price * item.Quantity);
                var strategy = PriceCalculator.GetStrategy(customer.TypeCustomer);
                double finalTotal = strategy.Calculate(total);
                Console.WriteLine($"Totale ordine: {finalTotal:F2} EUR");

                sender.Send(order);
                continua = sender.continueShopping();
            }

            Console.WriteLine("Arrivederci");
        }
    }
}
