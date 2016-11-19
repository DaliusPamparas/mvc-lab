using System.Web.Mvc;

namespace Mvc_Area_tut_1.Areas.Employeer
{
    public class EmployeerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Employeer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Employeer_default",
                "Employeer/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}