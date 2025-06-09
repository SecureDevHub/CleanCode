using GuroDemo.Decoration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Services
{
    internal class ProductDecoratorService
    {
        public static Product AddDecorator(Product p)
        {
            Console.WriteLine("Want to add insurance? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
                p = new InsuranceDecorator(p);

            Console.WriteLine("Want to add packaging? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
                p = new PackagingDecorator(p);

            Console.WriteLine("Do you want to add the warranty extension? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
                p = new ExtensionDecorator(p);

            Console.WriteLine($"Selected: {p.GetName()}");
            Console.WriteLine($"Total price: {p.GetPrice():F2} EUR");

            return p;
        }
    }
}
