using ProjectStar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectStar.Controllers
{
    public class HomeController : Controller
    {
        Kelebek kelebek = new Kelebek();
        public ActionResult Index()
        {
            return View(kelebek.GetKelebekList());
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