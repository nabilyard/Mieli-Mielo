using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mieli_Mielo.Models
{
    public class SignUp
    {
        [Key]
        public int SignUpId { get; set; }
       
        public string Email{ get; set; }

        [Display(Name = "Mot de Passe")]
        public string PassWord { get; set; }
        

    }
}