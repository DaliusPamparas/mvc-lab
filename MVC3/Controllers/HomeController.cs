using MVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVC3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Album> albums = new List<Album>();

            using (ApplicationDbContext cx = new ApplicationDbContext())
            {
                albums = cx.Albums
                    .Include(a=>a.Galleries.Select(g=>g.Photos))
                    .ToList();
            }
                return View(albums);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}