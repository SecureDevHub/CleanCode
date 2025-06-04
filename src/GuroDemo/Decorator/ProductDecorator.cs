using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    internal abstract class ProductDecorator : Product
    {
        protected readonly Product _product;

        protected ProductDecorator(Product product)
        {
            _product = product;
        }

        public override string GetName() => _product.GetName();
        public override double GetPrice() => _product.GetPrice();
    }
}
