using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class EmailNotifier : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Inviata email a {order.Customer.Email}");
        }
    }
}
