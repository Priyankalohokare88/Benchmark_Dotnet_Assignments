using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult GetName(int empid)
        {
            var emp = new[]
            {
                new{empid=1,empname="priya",salary=34555},
                new{empid=2,empname="sneha",salary=23444},
                new {empid=3,empname="neha",salary=9000}
            };
            string name1 = null;
            foreach(var item in emp)
            {
                if(item.empid==empid)
                {
                     name1=item.empname;
                }
            }
            return new ContentResult() { Content = name1 };
           // return Content(name1, "text/plain");
        }
        public ActionResult GetPaySlip(int empid)
        {
            string filename = "~/PaySlip" + empid + ".pdf";
            return File(filename,"application/pdf");
        }

        public ActionResult Urldemo(int empid)
        {
            var emp = new[]
            {
                new{empid=1,empname="priya",salary=34555},
                new{empid=2,empname="sneha",salary=23444},
                new {empid=3,empname="neha",salary=9000}
            };
            string url = null;
            foreach (var item in emp)
            {
                if (item.empid == empid)
                {
                    url = "https://www.facebook.com"+empid;
                }
            }
            if(url == null)
            {
                return Content("employee not found");
            }
            else
            {
                return Redirect(url);
            }
        }
    }
}