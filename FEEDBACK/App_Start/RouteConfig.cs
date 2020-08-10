﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FEEDBACK
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Đăng nhập",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "login", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                    name: "Xem DM_KS",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                    name: "Sua-KS",
                    url: "admin/{controller}/{action}/{id}",
                    defaults: new { controller = "Danhmuc_KS", action = "Index", id = UrlParameter.Optional }
                );
           






        }
    }
}
