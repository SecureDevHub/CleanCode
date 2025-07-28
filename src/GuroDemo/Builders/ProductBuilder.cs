using GuroDemo.Decoration;
using System;

namespace GuroDemo.Builders
{
    internal class ProductBuilder
    {
        private string _name;
        private double _price;
        private bool Insurance { get ; set; }
        private bool Packing { get; set; }
        private bool Extension {  get; set; }

        public ProductBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public ProductBuilder WithPrice(double price)
        {
            _price = price;
            return this;
        }

        public ProductBuilder AddInsurance(bool insurance)
        {
            Insurance = insurance;
            return this;
        }
        public ProductBuilder AddPacking(bool packing)
        {
            Packing = packing;
            return this;
        }

        public ProductBuilder AddExtention(bool extention)
        {
            Extension = extention;
            return this;
        }

        public Product build()
        {
            if (string.IsNullOrWhiteSpace(_name))
                throw new InvalidOperationException("Name is required.");
            if (_price <= 0)
                throw new InvalidOperationException("Price cannot be 0 or less");
            
            return new BaseProduct(_name, _price);
        }
    }
}
