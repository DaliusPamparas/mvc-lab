using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab1_3.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            
                if(Session ["user"] == null)
                {
                    return RedirectToAction("Login", "Login");

                }
                return View();
            
            
        }
    }
}