using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo.Decoration
{
    internal class InsuranceDecorator : ProductDecorator
    {
        public InsuranceDecorator(Product product) : base(product) { }

        public override string GetName() => _product.GetName() + " + Assicurazione";
        public override double GetPrice() => _product.GetPrice() + 5.99;
    }
}
