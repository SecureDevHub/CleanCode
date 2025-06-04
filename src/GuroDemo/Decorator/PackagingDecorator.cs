using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    internal class PackagingDecorator : ProductDecorator
    {
        public PackagingDecorator(Product product) : base(product) { }

        public override string GetName() => _product.GetName() + " + Imballaggio";
        public override double GetPrice() => _product.GetPrice() + 2.49;
    }
}
