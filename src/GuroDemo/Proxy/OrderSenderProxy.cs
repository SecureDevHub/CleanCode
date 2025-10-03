using GuroDemo.InterfacesAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.proxy
{
    internal class OrderSenderProxy : IOrderSender
    {
        private readonly IOrderSender _realSender;

        public OrderSenderProxy(IOrderSender realSender)
        {
            _realSender = realSender;
        }

        public void Send(Order order)
        {
            if (order.Items.Count == 0)
            {
                Console.WriteLine("Order is empty. Sending aborted.");
                return;
            }

            _realSender.Send(order);
        }

        public bool ContinueShopping()
        {
            return _realSender.ContinueShopping();
        }
    }


}
