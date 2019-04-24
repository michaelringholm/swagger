package com.opusmagus;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.view.RedirectView;

@Controller
public class MainController {
    @RequestMapping("/")
    public RedirectView Welcome() throws Exception {        
        return new RedirectView("/swagger-ui.html");
    }
}