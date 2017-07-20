using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestTask
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("public/{*pathInfo}");
            routes.IgnoreRoute("resizer.debug");
            routes.IgnoreRoute("resizer.debug.ashx");
        }

        public static void Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
