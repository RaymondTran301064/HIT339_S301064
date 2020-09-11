using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECorpSales.Models;

namespace ECorpSales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ECorpSales.Models.Items> Items { get; set; }
        public DbSet<ECorpSales.Models.Sales> Sales { get; set; }
        public DbSet<ECorpSales.Models.Carts> Carts { get; set; }
    }
}
