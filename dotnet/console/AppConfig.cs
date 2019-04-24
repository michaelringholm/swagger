using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;

namespace com.opusmagus
{
    public static class AppConfig
    {

        public static ServiceProvider BuildServiceProvider()
        {
            var sc = new ServiceCollection();
            sc.AddSingleton<ILogger, ConsoleLogger>();
            var orderServiceMock = new Mock<IOrderService>();            
            orderServiceMock.Setup(os => os.ValidateOrder(It.IsAny<OrderDTO>())).Returns(true);
            sc.AddSingleton<IOrderService>(orderServiceMock.Object);
            var paymentServiceMock = new Mock<IPaymentService>();
            paymentServiceMock.Setup(ps => ps.ProcessPayment(It.IsAny<OrderDTO>())).Returns(true);
            sc.AddSingleton<IPaymentService>(paymentServiceMock.Object);
            sc.AddSingleton<ProcessOrderCommand, ProcessOrderCommand>();
            return sc.BuildServiceProvider();
        }
    }
}