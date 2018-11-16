using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mieli_Mielo.Models
{
    public class SignUp
    {
        [Key]
        [ForeignKey("Utilisateur")]
        
        public int UserID { get; set; }

        
        [Required(ErrorMessage = "Adresse e-mail estr equise")]
        [EmailAddress(ErrorMessage = "Addresse e-mail Invalide !!!")]
        public string Email{ get; set; }

        [Display(Name = "Mot de Passe")]
        public string PassWord { get; set; }

        [Display(Name = "Confirmer Mot de Passe")]
        public string ConfirmPassWord { get; set; }


        public virtual Utilisateur Utilisateur { get; set; }
    }
}