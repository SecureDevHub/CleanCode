using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    public class VipPriceStrategy : IPriceStrategy
    {
        public double Calculate(double baseTotal)
        {
            if (baseTotal < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine("20% di sconto VIP applicato.");
            Console.WriteLine("Spedizione gratuita.");
            return baseTotal * 0.8;
        }
    }
}
