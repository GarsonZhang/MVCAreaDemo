using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace second
{
    public class SecondAreaRegistration : AreaRegistration
    {
        //区域名称
        public override string AreaName
        {
            get
            {
                return "Second";
            }
        }
        //注册区域路由
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Second_default",
                "Second/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}