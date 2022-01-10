using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Photography_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ISEM 551 Assignment 1";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            var contacts = Contacts.GetContactData(); 
            return View(contacts);
        }

        public ActionResult Rural()
        {
            ViewBag.Message = "Rural photography from around the world.";

            return View();
        }
        public ActionResult Urban()
        {
            ViewBag.Message = "Urban photography from around the world.";

            return View();
        }
    }
}