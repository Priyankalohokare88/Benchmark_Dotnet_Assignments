using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ActionResultAssignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string  st)
        {
            if (st == "sample")
            {
                string filename = "~/Sample" + ".pdf";
                return File(filename, "application/pdf");
            }
            else if (st == "gotoabout")
            {
                return RedirectToAction("About");
            }
            else if (st == "login")
            {
                return View("login");
            }
            else
            {
                string st1 = "You Entered: " + st;
                return Content(st1);
            }
        }
        public ActionResult About()
        {
            return Content("About Content Here");
        }
    }
}