using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorViewEngineDemo.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult StudentMarks()
        {
            ViewBag.StudentId = 1;
            ViewBag.StudentName = "Priyanka";
            ViewBag.StudentClass = "Symsc";
            ViewBag.StudentMark = 50;
            ViewBag.subject = new List<string>() {"Maths","English","Physics" };
            return View();
        }
    }
}