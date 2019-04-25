using System;
using Microsoft.AspNetCore.Mvc;

namespace com.opusmagus
{
    [ApiController]
    public class ManagementController
    {
        [HttpGetAttribute("/health")]        
        public dynamic Health() {
            return true;
        }

        [HttpGetAttribute("/time")]        
        public ActionResult<dynamic> Time() {
            return DateTime.Now;
        }        
    }
}