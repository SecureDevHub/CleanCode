using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class PriceCalculator
    {
        public static IPriceStrategy GetStrategy(CustomerTypeEnum type)
        {
            switch (type)
            {
                case CustomerTypeEnum.Vip:
                    return new VipPriceStrategy();
                case CustomerTypeEnum.Azienda:
                    return new CompanyPriceStrategy();
                default:
                    return new PrivatePriceStrategy();
            }
        }
    }
}
