using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    public class PackagingDecorator : ProductDecorator
    {
        public PackagingDecorator(Product product) : base(product) { }

        public override string GetName() => _product.GetName() + " + Packaging";
        public override double GetPrice() => _product.GetPrice() + 2.49;
    }
}
