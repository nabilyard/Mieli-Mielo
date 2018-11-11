using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mieli_Mielo.Models
{
    public class Login
    {
        [Display(Name ="Login" )]
        public string User_Login { get; set; }

        [Display(Name = "Mot de Passe")]
        public string MotDePasse { get; set; }
    }
}