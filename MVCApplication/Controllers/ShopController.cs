using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}