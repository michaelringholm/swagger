package com.opusmagus;

public interface IOrderService {
	public boolean ValidateOrder(OrderDTO order);
	public void shipOrder(OrderDTO order);
	public OrderDTO GetOrder(String shoppingCardId);
}