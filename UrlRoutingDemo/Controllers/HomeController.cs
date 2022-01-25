using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlRoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        [Route("Home/GetId/{pname}")]
        public ActionResult Index(string pname)
        {
            int id1=0;
            var product = new[]
            {new {pname="iphone" ,id=1},
            new {pname="tv" ,id=2},
            new {pname="camera" ,id=3}};
            foreach(var item in product)
            {
                if(item.pname == pname)
                {
                     id1=item.id;
                }
            }
            return Content( id1.ToString());
        }
        [Route("Home/GetName/{pid:int?}")]
        public ActionResult GetName(int pid)
        {
            string pname = "null";
            var product = new[]
            {new {pname="iphone" ,id=1},
            new {pname="tv" ,id=2},
            new {pname="camera" ,id=3}};
            if (pid == null)
            {
                return Content("Please enter product id");
            }
            else
            {
                foreach (var item in product)
                {
                    if (item.id==pid)
                    {
                        pname = item.pname;
                    }
                }

                return Content(pname);
            }
        }
    }
}