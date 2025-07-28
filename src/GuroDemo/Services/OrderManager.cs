using System;
using System.Collections.Generic;
using System.Linq;
using GuroDemo.Decoration;

namespace GuroDemo.Services
{
    internal class OrderManager
    {
        private readonly OrderSender _sender = OrderSender.GetInstance();

        public void Run(Order order, ProductSelector selector)
        {
            _sender.RegisterObserver(new OrderPrinter(order));
            _sender.RegisterObserver(new EmailNotifier());

            bool continua = true;

            while (continua)
            {
                OrderItem item = CreateOrderItem(selector);
                order.AddItem(item.Product, item.Quantity);

                PrintTotal(order);
                continua = _sender.ContinueShopping();
            }

            Console.WriteLine("GoodBye " + order.Customer.Name);
        }

        private OrderItem CreateOrderItem(ProductSelector selector)
        {
            selector.ShowAvailableProducts();
            Product product = selector.GetProduct();
            int quantity = selector.GetProductQuantity(product);
            product = ProductDecoratorService.AddDecorator(product);

            return new OrderItem(product, quantity);
        }

        private void PrintTotal(Order order)
        {
            double total = order.Items.Sum((item => (item.Product.GetPrice() * item.Quantity)));
            IPriceStrategy strategy = PriceCalculator.GetStrategy(order.Customer.TypeCustomer);
            double finalTotal = strategy.Calculate(total);

            _sender.Send(order);
            Console.WriteLine($"Order total: {finalTotal:F2} EUR");
        }
    }
}
