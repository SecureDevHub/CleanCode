using GuroDemo.Decoration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class OrderPrinter : IOrderObserver
    {
        private readonly Order _order;

        public OrderPrinter(Order order)
        {
            _order = order;
        }

        public void Update(Order order)
        {
            Console.WriteLine("Dettagli ordine:");
            Console.WriteLine($"         Cliente: {_order.Customer.Name} ({_order.Customer.Email})");
            Console.WriteLine($"         Data: {_order.CreatedAt:dd/MM/yyyy HH:mm}");
            foreach (var item in _order.Items)
            {
                string line = $"         - {item.Product.GetName()} x{item.Quantity} = {item.GetSubtotal().ToString("C2", CultureInfo.CurrentCulture)}";
                Console.WriteLine(line);
            }
        }

        public bool RemoveItem()
        {
            Console.WriteLine("vuoi rimuovere un prodotto dalla lista?");
            string response = Console.ReadLine();
            return (response == "s" || response == "si");
        }
    }
}
