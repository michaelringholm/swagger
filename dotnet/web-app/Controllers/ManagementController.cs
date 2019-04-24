using System;
using Microsoft.AspNetCore.Mvc;

namespace com.opusmagus
{
    public class ManagementController : Controller
    {
        [HttpGetAttribute("/health")]        
        public dynamic Health() {
            return true;
        }

        [HttpGetAttribute("/time")]        
        public dynamic Time() {
            return DateTime.Now;
        }        
    }
}