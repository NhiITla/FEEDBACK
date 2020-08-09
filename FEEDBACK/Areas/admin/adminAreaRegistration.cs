using System.Web.Mvc;

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
                "admin_Danhsach_KS",
                "admin /{ controller}/{ action}/{ id}",
                new { Controller = "Admin", action = "Danhsach_KS", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "admin_DanhmucKS_Edit",
               "admin /{ controller}/{ action}/{ id}",
               new { Controller = "Danhmuc_KS", action = "Edit", id = UrlParameter.Optional }
           );




        }

    }
}