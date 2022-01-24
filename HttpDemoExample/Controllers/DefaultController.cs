using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpDemoExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            ViewBag.Url = Request.Url;
            ViewBag.Path=Request.Path;
            ViewBag.Browser = Request.Browser;
            ViewBag.Querystring = Request.QueryString["n"];
            ViewBag.Method = Request.HttpMethod;
            ViewBag.Header = Request.Headers;
            Response.Write("Hello from Response");
            Response.Headers["server"] = "MyServer";
            return View();
        }
    }
}