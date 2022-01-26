using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelExample.Models;

namespace ModelExample.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
   
        public ActionResult Index()
        {
            List<Product> prod = new List<Product>()
            {
                new Product(){Id=1,Name="tv",Price=23900},
                new Product(){Id=2,Name="mobile",Price=24400},
                new Product(){Id=3,Name="camera",Price=29090},
                new Product(){Id=4,Name="iphone",Price=27009}

            };
            ViewBag.prod=prod;
            return View();
        }
        public ActionResult Details(int Id)
        {
            List<Product> prod = new List<Product>()
            {
                new Product(){Id=1,Name="tv",Price=23900},
                new Product(){Id=2,Name="mobile",Price=24400},
                new Product(){Id=3,Name="camera",Price=29090},
                new Product(){Id=4,Name="iphone",Price=27009}

            };
            Product matchprod = null;
            foreach(var item in prod)
            {
                if(item.Id==Id)
                {
                    matchprod=item;
                }
            }
            ViewBag.product=matchprod;
            return View();
        }

    }
}