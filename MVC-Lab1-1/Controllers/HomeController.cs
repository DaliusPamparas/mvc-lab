using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Lab1_1.Models;
	

namespace MVC_Lab1_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
         
            //List<photo> Gallery = new List<photo>();


            ViewBag.ArticleName = "Gallery";
            
            return View();

        }
        public ViewResult Addphoto()
        {
            return View();
        }
    }
}