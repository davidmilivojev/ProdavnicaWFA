using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ProdavnicaPica.DataAccess.Entities;

namespace ProdavnicaPica.DataAccess
{
    

    public class ProdavnicaPicaContext : DbContext
    {

        public virtual DbSet<Operater> Operaters { get; set; }
        public virtual DbSet<Pice> Pices { get; set; }
        public virtual DbSet<Prodaja> Prodajas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operater>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Operater>()
                .HasMany(e => e.Prodajas)
                .WithRequired(e => e.Operater)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pice>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Pice>()
                .Property(e => e.Cena)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pice>()
                .HasMany(e => e.Prodajas)
                .WithRequired(e => e.Pice)
                .WillCascadeOnDelete(false);
        }
    }
}
