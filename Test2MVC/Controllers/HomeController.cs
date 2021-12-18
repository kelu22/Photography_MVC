using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test2MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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