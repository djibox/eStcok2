using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eStock2.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public int Prix { get; set; }
        public int Quantite { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }
    }
}