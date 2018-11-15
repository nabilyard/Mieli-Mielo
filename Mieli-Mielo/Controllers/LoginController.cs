using Microsoft.AspNet.Identity;
using Mieli_Mielo.DAL;
using Mieli_Mielo.Models;
using Mieli_Mielo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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


        [AllowAnonymous]
        public ActionResult Login()
        {
            
            return View();
        }

          private bool ValidateUser(SignUp sign)
            {
            var usr = _context.InfoLogin.Where(u => u.Email == sign.Email && u.PassWord == sign.PassWord).FirstOrDefault();
            if (usr != null)
            {
                Session["UserID"] = usr.Email.ToString();
                Session["UserName"] = usr.Utilisateur.Nom.ToString();
                return true;
            }
            else
            {
                return false;
            }

            //// Pour ce tutoriel, j'utilise une validation extrêmement sécurisée...
            //return login == password;
        }




        [HttpPost]
        public ActionResult Login(SignUp sign)
        {
            //var UtilisateurLoginViewModel = ViewModel;
            if (ValidateUser(sign)){

                

                // L'authentification est réussie, 
                // injecter l'identifiant utilisateur dans le cookie d'authentification :
                var loginClaim = new Claim(ClaimTypes.NameIdentifier, sign.Email);
                var claimsIdentity = new ClaimsIdentity(new[] { loginClaim }, DefaultAuthenticationTypes.ApplicationCookie);
                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(claimsIdentity);
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong");
            }





            //var usr = _context.InfoLogin.Where(u => u.Email == sign.Email && u.PassWord == sign.PassWord).FirstOrDefault();
            //if (usr != null)
            //{
            //    Session["UserID"] = usr.Email.ToString();
            //    Session["UserName"] = usr.Utilisateur.Nom.ToString();

            //    // L'authentification est réussie, 
            //    // injecter l'identifiant utilisateur dans le cookie d'authentification :
            //    var loginClaim = new Claim(ClaimTypes.NameIdentifier, sign.Email);
            //    var claimsIdentity = new ClaimsIdentity(new[] { loginClaim }, DefaultAuthenticationTypes.ApplicationCookie);
            //    var ctx = Request.GetOwinContext();
            //    var authenticationManager = ctx.Authentication;
            //    authenticationManager.SignIn(claimsIdentity);


            //    return RedirectToAction("LoggedIn");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Username or password is wrong");
            //}
            return View();
        }





        public ActionResult LoggedIn()
        {
            if(Session["UserID"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }





        [HttpPost]
        public ActionResult Create(UtilisateurLoginViewModel ViewModel)
        {
            var UtilisateurLoginViewModel = ViewModel;

            _context.Utilisateurs.Add(ViewModel.User);


            _context.InfoLogin.Add(ViewModel.SignUser);
            _context.SaveChanges();


            return RedirectToAction("Index", "Shipping");
        }



        public ActionResult SignUp()
        {

            var viewModel = new UtilisateurLoginViewModel();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Logout()
        {

            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignOut();

            // Rediriger vers la page d'accueil :
            return RedirectToAction("Index", "Home");
        }
        
    }
}