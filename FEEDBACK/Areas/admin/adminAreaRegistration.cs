﻿using System.Web.Mvc;

namespace FEEDBACK.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }
        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin Index",
                "admin/{controller}/{action}/{id}",
                new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Edit",
                "admin/{controller}/{action}/{id}",
                new { controller="Danhmuc_KS" ,action = "Index", id = UrlParameter.Optional }
            );



            context.MapRoute(
                "Tim kiem KS",
                "admin/{controller}/{action}/{id}",
                new { controller = "Timkiem_KS", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Tim kiem ma loai",
                "admin/{controller}/{action}/{id}",
                new { controller = "Search_KS", action = "Search", id = UrlParameter.Optional }
            );





        }

    }
}