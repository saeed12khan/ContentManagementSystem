﻿using System.Web.Mvc;

namespace Nettex.WebMVC.Areas.Manage
{
    public class ManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Manage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Manage_default",
                "Manage/{controller}/{action}/{id}",
                new { controller = "Category", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}