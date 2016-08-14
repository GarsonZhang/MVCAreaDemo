using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Manager
        public ActionResult Index()
        {
            return View();
        }
    }
}