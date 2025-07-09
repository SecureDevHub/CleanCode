using GuroDemo;
using GuroDemo.Decoration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo_Shopping.Tests.Decoration
{
    public class Decoration
    {
        [Theory]
        [InlineData(true, false, false, "Mouse + Insurance", 25.99 + 5.99)] 
        [InlineData(false, true, false, "Mouse + Packaging", 25.99 + 2.49)]           
        [InlineData(false, false, true, "Mouse + Warranty extension", 25.99 + 7.99)]
        [InlineData(true, true, true, "Mouse + Insurance + Packaging + Warranty Extension", 25.99 + 5.99 + 2.49 + 7.99)]
        [InlineData(false, false, false, "Mouse", 25.99)]
        public void DecorateProduct_CorrectlyCombinesDecorators(
            bool addInsurance,
            bool addPackaging,
            bool addExtension,
            string expectedName,
            double expectedPrice)
        {
            // Arrange
            Product product = new BaseProduct("Mouse", 25.99);

            if (addInsurance)
                product = new InsuranceDecorator(product);
            if (addPackaging)
                product = new PackagingDecorator(product);
            if (addExtension)
                product = new ExtensionDecorator(product);

            // Act & Assert
            //Assert.Equal(expectedName, product.GetName());
            Assert.Equal(expectedName, product.GetName(), ignoreCase: true);
            Assert.Equal(expectedPrice, product.GetPrice(), 3); // toleranza floating point
        }
    }
}
