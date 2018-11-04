using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mieli_Mielo.Models
{
    public class Commande
    {
        [Key]
        public int CommandeID { get; set; }
        [Required]
        public DateTime DateCommande { get; set; }

        public virtual Utilisateur User { get; set; }
        public int UtilisateurId { get; set; }

        public virtual ICollection<Produit> Produits { get; set; }
    }
}