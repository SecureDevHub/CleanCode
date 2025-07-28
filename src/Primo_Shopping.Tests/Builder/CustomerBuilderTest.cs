using GuroDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo_Shopping.Tests.Builder
{
    public class CustomerBuilderTest
    {
        [Fact]
        public void CustomerBuilder_ShouldCreateCustomer_WhenNameIsValid()
        {
            var customer = new CustomerBuilder()
                .WithName("Mario")
                .WithEmail("mario@email.com")
                .WithType(CustomerTypeEnum.Private)
                .Build();

            Assert.Equal("Mario", customer.Name);
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void CustomerBuilder_ShouldThrowWhenNameIsNullOrEmpty(string? name)
        {
            var builder = new CustomerBuilder();

            Assert.Throws<ArgumentException>(() =>
                builder.WithName(name)
                       .WithEmail("test@email.com")
                       .WithType(CustomerTypeEnum.Private)
                       .Build()
            );
        }

        [Theory]
        [InlineData("A")]
        [InlineData("X")]
        public void CustomerBuilder_ShouldThrowWhenNameIsTooShort(string name)
        {
            var builder = new CustomerBuilder();

            Assert.Throws<ArgumentException>(() =>
                builder.WithName(name)
                       .WithEmail("test@email.com")
                       .WithType(CustomerTypeEnum.Private)
                       .Build()
            );
        }

        [Theory]
        [InlineData("Mari@")]
        [InlineData("Jo#hn")]
        [InlineData("Luc@123")]
        [InlineData("Al€#ssio")]
        public void CustomerBuilder_ShouldThrow_WhenNameContainsSpecialCharacters(string name)
        {
            var builder = new CustomerBuilder();

            Assert.Throws<ArgumentException>(() =>
                builder.WithName(name)
                       .WithEmail("test@email.com")
                       .WithType(CustomerTypeEnum.Private)
                       .Build()
            );
        }

    }
}
