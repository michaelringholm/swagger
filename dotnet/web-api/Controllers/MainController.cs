using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace com.opusmagus.webapi.Controllers
{    
    [Controller]
    public class MainController : ControllerBase
    {
        [Route("/")]
        public RedirectResult Index()
        {
            return Redirect("/swagger");
        }
    }
}