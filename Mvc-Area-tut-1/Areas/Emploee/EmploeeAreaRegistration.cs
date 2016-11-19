using System.Web.Mvc;

namespace Mvc_Area_tut_1.Areas.Emploee
{
    public class EmploeeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Emploee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Emploee_default",
                "Emploee/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}