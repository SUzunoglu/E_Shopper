using E_Shopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shopper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new NorthwindEntities())
            {
                var products = (from product in context.Products select product).ToList();
                ViewBag.Data = products;
                return View();
            }
        }
    }
}