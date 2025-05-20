using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class AziendaPriceStrategy: IPriceStrategy
    {
        public double Calculate(double baseTotal)
        {
            Console.WriteLine("10% di sconto aziendale applicato.");
            Console.WriteLine("Spedizione: 10€");
            return baseTotal * 0.9 + 10;
        }
    }
}
