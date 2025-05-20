using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class PriceCalculator
    {
        public static IPriceStrategy GetStrategy(TypeCustomerEnum type)
        {
            switch (type)
            {
                case TypeCustomerEnum.Vip:
                    return new VipPriceStrategy();
                case TypeCustomerEnum.Azienda:
                    return new AziendaPriceStrategy();
                default:
                    return new PrivatoPriceStrategy();
            }
        }
    }
}
