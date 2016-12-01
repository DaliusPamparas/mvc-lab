using Kunskap_ajax1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kunskap_ajax1.Controllers
{
    public class HomeController : Controller
    {
        static List<adressBook> adressbook = new List<adressBook>();


        // GET: Home
        public ActionResult Index()
        {
            adressBook insAdressBook = new adressBook();
            return View(insAdressBook);
        }

        [HttpPost]
        public ActionResult Create(adressBook Adressbook)
        {
            
            adressbook.Add(Adressbook);
            return PartialView("List", adressbook);
        }

        public ActionResult All()
        {
            return PartialView("List", adressbook);
        }
    }
}