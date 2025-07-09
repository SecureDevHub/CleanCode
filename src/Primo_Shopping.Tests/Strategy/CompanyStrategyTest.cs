using GuroDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo_Shopping.Tests.Strategy
{
    public class CompanyStrategyTest
    {
        [Theory]
        [InlineData(100, 100 * 0.9 + 10)]  
        [InlineData(200, 200 * 0.9 + 10)]  
        [InlineData(0, 0 * 0.9 + 10)]
        public void Calculate_CompanyDiscount(double baseTotal, double expected)
        {
            // Arrange
            var strategy = new CompanyPriceStrategy();

            // Act
            var result = strategy.Calculate(baseTotal);

            // Assert (tolleranza floating point)
            Assert.Equal(expected, result, 2);
        }
    }
}
