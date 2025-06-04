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

        // BEFORE:
        // foreach (var item in products) { Console.WriteLine(item.Name); }
        // AFTER: shows full product info (name + price)
        public void ShowAvailableProducts()
        {
            Console.WriteLine("Available products:");
            foreach (var item in products)
            {
                Console.WriteLine($"- {item.Name} ({item.Price} EUR)");
            }
        }

        // BEFORE:
        // returned null and used foreach to search
        // AFTER:
        // safer approach using LINQ, explicit control flow, exception on failure
        public Product GetProduct(int maxAttempts = 3)
        {
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter product name:");
                string input = Console.ReadLine();

                // LINQ: simplified search
                var product = products.FirstOrDefault(p =>
                    p.Name.Equals(input, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                    return product;

                Console.WriteLine("Product not found. Try again.");
                attempts++;
            }

            throw new InvalidOperationException("Too many failed attempts. Product not found.");
        }

        // BEFORE:
        // int.Parse without validation
        // AFTER:
        // uses int.TryParse to avoid crashes on invalid input
        public int GetProductQuantity(Product product)
        {
            int quantity;
            Console.WriteLine($"Enter quantity for {product.Name}:");

            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number:");
            }

            return quantity;
        }
    }
}
