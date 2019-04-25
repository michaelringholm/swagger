using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace com.opusmagus.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        [HttpGet("health")]
        public ActionResult<dynamic> Health()
        {
            return new { Status="Healthy", Time=DateTime.Now };
        }

        [HttpGet("time")]
        public ActionResult<dynamic> Post()
        {
            return new { CurrentServerTime=DateTime.Now };
        }
    }
}
