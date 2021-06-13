using E_Shopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shopper.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            using (var context = new NorthwindEntities())
            {
                context.Products.Add(product);
                context.SaveChanges();
                return View();
            }

        }
    }
}