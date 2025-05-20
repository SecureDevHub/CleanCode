using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class VipPriceStrategy : IPriceStrategy
    {
        public double Calculate(double baseTotal)
        {
            Console.WriteLine("20% di sconto VIP applicato.");
            Console.WriteLine("Spedizione gratuita.");
            return baseTotal * 0.8;
        }
    }
}
