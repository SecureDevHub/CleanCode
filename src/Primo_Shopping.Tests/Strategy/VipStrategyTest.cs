using Xunit;
using System;
using GuroDemo;

namespace Primo_Shopping.Tests.Strategy
{
    public class VipStrategyTest
    {
        [Theory]
        [InlineData(100, 80.0)]
        [InlineData(101, 80.8)]
        [InlineData(200, 160.0)]
        public void Calculate_VipStrategy(double baseTotal, double expected)
        {
            var strategy = new VipPriceStrategy();
            var result = strategy.Calculate(baseTotal);
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void Calculate_NegativeValue_ThrowsArgumentException()
        {
            // Arrange
            var strategy = new VipPriceStrategy();

            // Act + Assert
            Assert.Throws<ArgumentException>(() => strategy.Calculate(-10));
        }
    }
}
