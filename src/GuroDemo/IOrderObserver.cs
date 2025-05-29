using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal interface IOrderObserver
    {
        void Update(Order order);
    }
}
