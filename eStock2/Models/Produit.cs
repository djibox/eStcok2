using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eStock2.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        [DisplayName("Prix de vente")]
        public int Prix { get; set; }
        public int Quantite { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date de création")]
        public DateTime DateCreation { get; set; }
        [DisplayName("Date d'expiration")]
        [DataType(DataType.Date)]
        public DateTime DateExpiration { get; set; }
    }
}