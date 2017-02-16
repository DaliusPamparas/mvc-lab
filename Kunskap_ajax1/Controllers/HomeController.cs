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
            Adressbook.ID = Guid.NewGuid();
            adressbook.Add(Adressbook);
            return PartialView("List", adressbook);
        }

        public ActionResult All()
        {
            return PartialView("List", adressbook);
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var delete = adressbook.First(x => x.ID == id);
            adressbook.Remove(delete);
            return PartialView("List", adressbook);
        }
        public ActionResult Edit(adressBook Adressbook)
        {
            var edit = adressbook.Find(x => x.ID == Adressbook.ID);
            return PartialView("Edit", edit);
        }
        [HttpPost]
        public ActionResult Edit(adressBook Adressbook, FormCollection formcollection)
        {
            var edit = adressbook.Find(x => x.ID == Adressbook.ID);
            edit.Name = Adressbook.Name;
            edit.Adress = Adressbook.Adress;
            edit.PhoneNumber = Adressbook.PhoneNumber;
            return PartialView("List", adressbook);
        }
    }
}