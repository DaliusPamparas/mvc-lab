using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab1_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.ArticleName = "Gallery";
            return View();
        }
        public ViewResult Addphoto()
        {
            return View();
        }
    }
}