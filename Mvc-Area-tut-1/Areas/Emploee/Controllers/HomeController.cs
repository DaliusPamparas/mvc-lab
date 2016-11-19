using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Area_tut_1.Areas.Emploee.Controllers
{
    public class HomeController : Controller
    {
        // GET: Emploee/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}