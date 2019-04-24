using System;

namespace com.opusmagus {

public interface IOrderService {
	bool ValidateOrder(OrderDTO order);
	void shipOrder(OrderDTO order);
	OrderDTO GetOrder(String shoppingCardId);
}
}