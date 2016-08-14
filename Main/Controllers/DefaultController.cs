using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Main.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public object get()
        {
            return "main API";
        }
    }
}
