using Mieli_Mielo.DAL;
using Mieli_Mielo.Models;
using Mieli_Mielo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mieli_Mielo.Controllers
{
    public class LoginController : Controller
    {
        private MielContext _context;

        public LoginController()
        {
            _context = new MielContext();
        }


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Create(UtilisateurLoginViewModel ViewModel)
        {
            var UtilisateurLoginViewModel = ViewModel;

            _context.Utilisateurs.Add(ViewModel.User);
            _context.SaveChanges();

            _context.InfoLogin.Add(ViewModel.SignUser);
            _context.SaveChanges();


            return RedirectToAction("Index", "Shipping");
        }



        public ActionResult SignUp()
        {

            var viewModel = new UtilisateurLoginViewModel();
            
            return View(viewModel);
        }

    }
}