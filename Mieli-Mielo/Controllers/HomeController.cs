using Mieli_Mielo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mieli_Mielo.Controllers
{
    public class HomeController : Controller
    {
        //private MielContext _context;
        //public HomeController()
        //{
        //    _context = new MielContext();
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}
        
        public ActionResult Index()
        {
           // var users = _context.Utilisateurs.ToList();
            ViewBag.Message = "Your application description page.";
            return View();//(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Notre Mission:";

            return View();
        }

      

        public ActionResult Recettes()
        {
            ViewBag.Message = "Your recepee page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}