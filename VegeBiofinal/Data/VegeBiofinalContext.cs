using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegeBiofinal.Models;

namespace VegeBiofinal.Data
{
    public class VegeBiofinalContext : IdentityDbContext
    {
        public VegeBiofinalContext(DbContextOptions<VegeBiofinalContext> options) : base(options)
        {

        }
        public DbSet<Produto> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Product");

        }

    }
}