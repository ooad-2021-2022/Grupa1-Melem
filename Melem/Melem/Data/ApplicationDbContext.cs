using Melem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Melem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Kviz> Kviz { get; set; }
        public DbSet<Rutina> Rutina { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Sastojak> Sastojak { get; set; }
        public DbSet<Pitanje> Pitanje{ get; set; }
        public DbSet<Odgovor> Odgovor { get; set; }
        public DbSet<RutinaKorisnika> RutinaKorisnika { get; set; }
        public DbSet<SastojakIzProdukta> SastojakIzProdukta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Kviz>().ToTable("Kviz");
            modelBuilder.Entity<Produkt>().ToTable("Produkt");
            modelBuilder.Entity<Rutina>().ToTable("Rutina");
            modelBuilder.Entity<Sastojak>().ToTable("Sastojak");
            modelBuilder.Entity<Pitanje>().ToTable("Pitanje");
            modelBuilder.Entity<Odgovor>().ToTable("Odgovor");
            modelBuilder.Entity<RutinaKorisnika>().ToTable("RutinaKorisnika");
            modelBuilder.Entity<SastojakIzProdukta>().ToTable("SastojakIzProdukta");

            base.OnModelCreating(modelBuilder);
        }



    }
}
