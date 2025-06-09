using GuroDemo.Decoration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuroDemo
{
    internal class ProductSelector
    {
        private readonly List<Product> products;

        public ProductSelector(List<Product> _products)
        {
            products = _products;
        }

        public void ShowAvailableProducts()
        {
            Console.WriteLine("Available products:");
            foreach (var item in products)
            {
                Console.WriteLine($"- {item.GetName()} ({item.GetPrice()} EUR)");
            }
        }

        public Product GetProduct(int maxAttempts = 3)
        {
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter product name:");
                string input = Console.ReadLine();

                var product = products.FirstOrDefault(p =>
                    p.GetName().Equals(input, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                    return product;

                Console.WriteLine("Product not found. Try again.");
                attempts++;
            }

            throw new InvalidOperationException("Too many failed attempts. Product not found.");
        }

        public int GetProductQuantity(Product product)
        {
            int quantity;
            Console.WriteLine($"Enter quantity for {product.GetName()}:");

            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number:");
            }

            return quantity;
        }
    }
}
