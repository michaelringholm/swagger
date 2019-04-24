package com.opusmagus;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.slf4j.Logger;

@SpringBootApplication
@ComponentScan("com.opusmagus")
@ComponentScan("com.opusmagus.OrderController")
public class App implements CommandLineRunner
{
    public static void main( String[] args ) {
        SpringApplication.run(App.class);
    }

    @Autowired private Logger logger;
    
    @Override public void run(String... args) throws Exception {
        logger.info( "Swagger Demo - Started..." );
        logger.info( "Swagger Demo - Ended!" );
    }
}