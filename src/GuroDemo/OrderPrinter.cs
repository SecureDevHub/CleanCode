using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class OrderPrinter
    {
        private readonly Order _order;

        public OrderPrinter(Order order)
        {
            _order = order;
        }

        public void Print()
        {
            Console.WriteLine("Dettagli ordine:");
            Console.WriteLine($"Cliente: {_order.Customer.Name} ({_order.Customer.Email})");
            Console.WriteLine($"Data: {_order.CreatedAt:dd/MM/yyyy HH:mm}");

            foreach (var item in _order.Items)
            {
                string line = $"- {item.Product.Name} x{item.Quantity} = {item.GetSubtotal().ToString("C2", CultureInfo.CurrentCulture)}";
                Console.WriteLine(line);
            }

            Console.WriteLine("Totale ordine: " + _order.GetTotal().ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}
