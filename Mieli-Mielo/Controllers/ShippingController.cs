using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mieli_Mielo.Controllers
{
    [Authorize]
    public class ShippingController : Controller
    {
        // GET: Shipping
        public ActionResult Index()
        {
            return View();
        }
    }
}