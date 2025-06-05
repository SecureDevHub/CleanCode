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
            Console.WriteLine("Vuoi aggiungere l'assicurazione? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
                p = new InsuranceDecorator(p);

            Console.WriteLine("Vuoi aggiungere l'imballaggio? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
                p = new PackagingDecorator(p);

            Console.WriteLine("Vuoi aggiungere l'estensione garanzia? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
                p = new ExtensionDecorator(p);

            Console.WriteLine($"Hai selezionato: {p.GetName()}");
            Console.WriteLine($"Prezzo totale: {p.GetPrice():F2} EUR");

            return p;
        }
    }
}
