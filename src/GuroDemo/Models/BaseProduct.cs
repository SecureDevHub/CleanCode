using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    public class BaseProduct : Product
    {
        private readonly string _name;
        private readonly double _price;

        public BaseProduct(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public override string GetName() => _name;
        public override double GetPrice() => _price;
    }

}
