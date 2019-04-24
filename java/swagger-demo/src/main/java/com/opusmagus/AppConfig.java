package com.opusmagus;

import org.mockito.Mockito;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import springfox.documentation.builders.PathSelectors;
import springfox.documentation.builders.RequestHandlerSelectors;
import springfox.documentation.spi.DocumentationType;
import springfox.documentation.spring.web.plugins.Docket;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

@Configuration
@EnableSwagger2
public class AppConfig {

    @Bean public Logger logger() {
        return LoggerFactory.getLogger("TemplateMethodPatternDemoLogger");
    }

    @Bean public IOrderService orderService() {
        IOrderService mock = Mockito.mock(IOrderService.class);
        Mockito.when(mock.ValidateOrder(Mockito.any())).thenReturn(true);
        OrderDTO order = new OrderDTO();
        order.Id = 10001;
        order.Hash = "DLAKSJDJDXJXJJXKJLKJXLKJS";
        Mockito.when(mock.GetOrder(Mockito.any())).thenReturn(order);
        return mock;
    }

    @Bean public IPaymentService paymentService() {
        IPaymentService mock = Mockito.mock(IPaymentService.class);
        Mockito.when(mock.processPayment(Mockito.any())).thenReturn(true);
        return mock;
    }
    
    @Bean public Docket api() { 
        return new Docket(DocumentationType.SWAGGER_2).select().apis(RequestHandlerSelectors.any()).paths(PathSelectors.any()).build();                                           
    }    
}