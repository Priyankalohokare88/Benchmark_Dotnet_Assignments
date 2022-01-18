using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class dashbordController : Controller
    {
        // GET: dashbord
        public ActionResult success()
        {
            return View();
        }
    }
}