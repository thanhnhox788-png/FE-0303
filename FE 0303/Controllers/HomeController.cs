using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FE_0303.Controllers
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

        public ActionResult VD3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VD4()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VD8()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}