using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Mieli_Mielo.Models
{
    public class Produit
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Nom { get; set; }
        public Double Prix { get; set; }

        public virtual Commande Com { get; set; }
    }
}