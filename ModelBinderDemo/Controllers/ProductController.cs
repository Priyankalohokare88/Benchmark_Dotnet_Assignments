using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinderDemo.Models;

namespace ModelBinderDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create1([Bind (Include   ="pid,pname")]Product p)
        {
            ViewBag.p = p;
            return View();
        }
    }
}