package com.opusmagus;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class OrderController {
    @Autowired ProcessOrderCommand processOrderCommand;

    @RequestMapping("/order/process")
    public Object ProcessOrder() throws Exception {
        return processOrderCommand.Execute(new ProcessOrderInputModel());
    }
}