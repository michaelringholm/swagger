package com.opusmagus;

import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.TimeZone;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ManagementController {
    @RequestMapping(method = RequestMethod.GET, path = "/health")
    public boolean Health() throws Exception {        
        return true;
    }

    @RequestMapping(method = RequestMethod.GET, path = "/time")
    public Calendar Time() throws Exception {        
        return GregorianCalendar.getInstance(TimeZone.getTimeZone("GMT+1:00"));
    }    
}