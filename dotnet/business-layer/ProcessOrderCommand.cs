using System;

namespace com.opusmagus
{
    public class ProcessOrderCommand : ICommand<ProcessOrderInputModel, OrderDTO>
    {
        IOrderService orderService;
        IPaymentService paymentService;

        public ProcessOrderCommand(IOrderService orderService, IPaymentService paymentService)
        {
            if (orderService == null) throw new Exception("orderService is null");
            if (paymentService == null) throw new Exception("paymentService is null");
            this.orderService = orderService;
            this.paymentService = paymentService;
        }

        public OrderDTO Execute(ProcessOrderInputModel input)
        {
            OrderDTO order = orderService.GetOrder(input.shoppingCardId);
            bool isValid = orderService.ValidateOrder(order);
            if (isValid)
            {
                bool paymentCompleted = paymentService.ProcessPayment(order);
                if (paymentCompleted)
                    orderService.shipOrder(order);
                else
                    throw new Exception("Payment failed!");
            }
            else
                throw new Exception("Order is invalid!");

            return order;
        }
    }
}