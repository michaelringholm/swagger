package com.opusmagus;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ProcessOrderCommand implements ICommand<ProcessOrderInputModel, OrderDTO> {
  @Autowired IOrderService orderService;
  @Autowired IPaymentService paymentService;

  @Override
  public OrderDTO Execute(ProcessOrderInputModel input) throws Exception {
    OrderDTO order = orderService.GetOrder(input.shoppingCardId);
    boolean isValid = orderService.ValidateOrder(order);
    if (isValid) {
      boolean paymentCompleted = paymentService.processPayment(order);
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