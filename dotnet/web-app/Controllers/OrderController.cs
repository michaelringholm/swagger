using Microsoft.AspNetCore.Mvc;

namespace com.opusmagus
{
    public class OrderController : Controller
    {
        private ProcessOrderCommand processOrderCommand;

        public OrderController(ProcessOrderCommand processOrderCommand) {
            this.processOrderCommand = processOrderCommand;
        }

        [HttpGetAttribute("/order/process")]        
        public dynamic ProcessOrder(){
            return processOrderCommand.Execute(new ProcessOrderInputModel());
        }
    }
}