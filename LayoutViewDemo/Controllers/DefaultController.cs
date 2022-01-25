using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
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
            return View();
        }
    }
}