﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace eStock2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Produit> Produits { get; set; }
    }
}