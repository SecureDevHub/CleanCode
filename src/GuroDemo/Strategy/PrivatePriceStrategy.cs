using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class PrivatePriceStrategy : IPriceStrategy
    {
        public double Calculate(double baseTotal)
        {
            Console.WriteLine("Spedizione: 5€");
            return baseTotal + 5;
        }
    }
}
