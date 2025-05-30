using System;

namespace GuroDemo
{
    internal class ProductBuilder
    {
        private string _name;
        private double _price;
        private bool _insurance;
        private bool _packing;
        private bool _extension;

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
            _insurance = insurance;
            return this;
        }
        public ProductBuilder AddPacking(bool packing)
        {
            _packing = packing;
            return this;
        }

        public ProductBuilder AddExtention(bool extention)
        {
            _extension = extention;
            return this;
        }

        public Product build()
        {
            if (string.IsNullOrWhiteSpace(_name))
                throw new InvalidOperationException("Name is required.");
            if (_price <= 0)
                throw new InvalidOperationException("Email is required.");
            
            return new Product(_name, _price, _extension, _insurance, _packing);
        }
    }
}
