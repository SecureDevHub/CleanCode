using Xunit;
using Moq;
using GuroDemo;
using GuroDemo.Decoration;
using GuroDemo.InterfacesAbstract;
using GuroDemo.proxy;

namespace Primo_Shopping.Tests.Proxy
{
    public class OrderSenderProxyTests
    {
        [Fact]
        public void Send_ShouldNotCallRealSender_WhenOrderIsEmpty()
        {
            // Arrange
            var mockSender = new Mock<IOrderSender>();
            var proxy = new OrderSenderProxy(mockSender.Object);

            var customer = new Customer("Test User", "test@test.com", CustomerTypeEnum.Private);
            var emptyOrder = new Order(customer);

            // Act
            proxy.Send(emptyOrder);

            // Assert
            mockSender.Verify(sender => sender.Send(It.IsAny<Order>()), Times.Never);
        }

        [Fact]
        public void Send_ShouldCallRealSender_WhenOrderIsValid()
        {
            // Arrange
            var mockSender = new Mock<IOrderSender>();
            var proxy = new OrderSenderProxy(mockSender.Object);

            var customer = new Customer("Test User", "test@test.com", CustomerTypeEnum.Private);
            var order = new Order(customer);
            order.AddItem(new BaseProduct("Mouse", 25.99), 1);

            // Act
            proxy.Send(order);

            // Assert
            mockSender.Verify(sender => sender.Send(It.Is<Order>(o => o.Items.Count == 1)), Times.Once);
        }

        [Fact]
        public void ContinueShopping_ShouldDelegateToRealSender()
        {
            // Arrange
            var mockSender = new Mock<IOrderSender>();
            mockSender.Setup(s => s.ContinueShopping()).Returns(true);

            var proxy = new OrderSenderProxy(mockSender.Object);

            // Act
            var result = proxy.ContinueShopping();

            // Assert
            Assert.True(result);
            mockSender.Verify(s => s.ContinueShopping(), Times.Once);
        }
    }
}
