using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace second.Controllers
{
    public class SecondAPIController : ApiController
    {
        [HttpGet]
        public object get()
        {
            return "API Second";
        }
    }
}
