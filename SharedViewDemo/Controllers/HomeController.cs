using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharedViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.contactno = "908-908-908";
            return View();
        }
    }
}