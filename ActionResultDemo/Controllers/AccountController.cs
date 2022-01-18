using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string username,string pass)
        {
            if(username=="111" && pass=="aaa")
            {
                return RedirectToAction("success","dashbord");
            }
            else
            {
                return RedirectToAction("Invalid");
            }
        }
        public ActionResult Invalid()
        {
            return View();
        }
    }
}