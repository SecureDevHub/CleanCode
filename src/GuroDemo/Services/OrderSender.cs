using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{

    internal class OrderSender
    {
        private static readonly OrderSender singleton = new OrderSender();
        private readonly List<IOrderObserver> observers = new List<IOrderObserver>();

        private OrderSender() { }

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

        public bool ContinueShopping()
        {
            Console.WriteLine("Do you want to buy another product?");
            string risposta = Console.ReadLine();
            return (risposta == "yes" || risposta == "Yes");
        }

    }
}
