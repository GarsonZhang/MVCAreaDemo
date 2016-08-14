using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Main.Areas.Admin.Controllers
{
    public class AdminAPIController : ApiController
    {
        [HttpGet]
        public object get()
        {
            return "Admin API";
        }
    }
}
