using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharedViewDemo.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
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
            ViewBag.contactno = "809-809-809";
            return View();
        }
    }
}