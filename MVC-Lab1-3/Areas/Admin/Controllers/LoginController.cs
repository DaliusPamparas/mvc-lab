using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Lab1_3.Areas.Admin.Models;

namespace MVC_Lab1_3.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            if ("admin".Equals(name) && "123".Equals(password))
                {
                Session["user"] = new User() { Login = name, Name = "Administrator" };
                return RedirectToAction("Index", "Home");
                }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            //or session["user"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}