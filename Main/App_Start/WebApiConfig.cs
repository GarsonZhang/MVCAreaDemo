using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Main
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Admin_DefaultApi",
                routeTemplate: "Admin/api/{controller}/{id}",
                defaults: new { area = "Admin", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "Second_DefaultApi",
               routeTemplate: "Second/api/{controller}/{id}",
               defaults: new { area = "Second", id = RouteParameter.Optional }
           );

        }
    }
}
