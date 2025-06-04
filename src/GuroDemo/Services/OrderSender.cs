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
        // 1. Istanza creata automaticamente e in modo thread-safe
        private static readonly OrderSender singleton = new OrderSender();
        private readonly List<IOrderObserver> observers = new List<IOrderObserver>();

        // 2. Costruttore privato per impedire istanze esterne
        private OrderSender() { }

        // 3. Metodo pubblico di accesso all’istanza
        public static OrderSender GetInstance() => singleton;

        public void RegisterObserver(IOrderObserver observer)
        {
            observers.Add(observer);
        }
        public void Send(Order order)
        {
            Console.WriteLine("Ordine inviato.");

            foreach (var observer in observers)
            {
                observer.Update(order);
            }
        }

        public bool continueShopping()
        {
            Console.WriteLine("Vuoi comprare altro?");
            string risposta = Console.ReadLine();
            return (risposta == "si" || risposta == "Si" || risposta == "yes" || risposta == "Yes") ? true : false;
        }

    }
}
