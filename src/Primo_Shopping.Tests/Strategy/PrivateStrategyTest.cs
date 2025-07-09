using GuroDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo_Shopping.Tests.Strategy
{
    public class PrivateStrategyTest
    {
        [Theory]
        [InlineData(100, 105)]  // 100 + 5
        [InlineData(0, 5)]      // 0 + 5
        [InlineData(49.99, 54.99)] // 49.99 + 5
        public void Calculate_PrivateShipping(double baseTotal, double expected)
        {
            // Arrange
            var strategy = new PrivatePriceStrategy();

            // Act
            var result = strategy.Calculate(baseTotal);

            // Assert (tolleranza decimali)
            Assert.Equal(expected, result, 2);
        }
    }
}
