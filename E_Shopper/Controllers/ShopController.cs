using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shopper.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop    
        public ActionResult Product()       
        {
            return View();
        }

    }
}