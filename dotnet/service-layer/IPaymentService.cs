namespace com.opusmagus
{
    public interface IPaymentService
    {
        bool ProcessPayment(OrderDTO order);
    }
}