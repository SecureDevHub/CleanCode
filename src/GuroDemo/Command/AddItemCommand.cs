using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Command
{
    internal class AddItemCommand : ICommand
    {
        private readonly Order _order;
        private readonly OrderItem _item;

        public AddItemCommand(Order order, OrderItem item)
        {
            _order = order;
            _item = item;
        }

        public void Execute()
        {
            _order.AddItem(_item.Product, _item.Quantity);
        }

        public void Undo()
        {
            _order.RemoveProduct(_item);
        }
    }
}

