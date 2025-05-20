using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{

    // Responsible for sending the order
    // Refactoring applied: Extract Class (OrderSender) to separate sending logic from order management
    internal class OrderSender
    {
        public void Send(Order order)
        {
            Console.WriteLine("Invio ordine in corso...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ordine inviato con successo!");
        }

        public bool continueShopping()
        {
            Console.WriteLine("Vuoi comprare altro?");
            string risposta = Console.ReadLine();
            return (risposta == "si" || risposta == "Si" || risposta == "yes" || risposta == "Yes") ? true : false;
        }

    }
}
