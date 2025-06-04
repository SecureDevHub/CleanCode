using GuroDemo.Decoration;
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

            List<Product> products = new List<Product>
            {
                new BaseProduct("Mouse", 25.99),
                new BaseProduct("Keyboard", 45.50),
                new BaseProduct("Monitor", 150.00),
            };

            ProductSelector selector = new ProductSelector(products);
            OrderSender sender = OrderSender.GetInstance();

            sender.RegisterObserver(new OrderPrinter(order));
            sender.RegisterObserver(new EmailNotifier());


            bool continua = true;
            while (continua)
            {
                selector.ShowAvailableProducts();
                Product product = selector.GetProduct();
                int quantity = selector.GetProductQuantity(product);
                product =selector.AddDecorator(product);
                order.AddItem(product, quantity);

                double total = order.Items.Sum(item => item.Product.GetPrice() * item.Quantity);
                IPriceStrategy strategy = PriceCalculator.GetStrategy(customer.TypeCustomer);
                double finalTotal = strategy.Calculate(total);

                sender.Send(order);
                Console.WriteLine($"Totale ordine: {finalTotal:F2} EUR");

                continua = sender.continueShopping();
            }

            Console.WriteLine("Arrivederci " + customer.Name);
        }
    }
}
