using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    public class ExtensionDecorator : ProductDecorator
    {
        public ExtensionDecorator(Product product) : base(product) { }

        public override string GetName() => _product.GetName() + " + Warranty extension";
        public override double GetPrice() => _product.GetPrice() + 7.99;
    }
}
