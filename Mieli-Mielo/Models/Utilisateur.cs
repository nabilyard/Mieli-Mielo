using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mieli_Mielo.Models
{
    public class Utilisateur
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public virtual ICollection<Commande> Commandes { get; set; }

        public SignUp SignUpId { get; set; }
    }
}