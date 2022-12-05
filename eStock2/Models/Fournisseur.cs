using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eStock2.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string AdressePhysique { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        //Liste des produits achetés chez ce fournisseur
        public ICollection<Produit> Produits { get; set; }
    }
}