using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<LibroContable> LibroContable { get; set; }
        public DbSet<AsientoContable> AsientoContable { get; set; }
        public DbSet<Concepto> Concepto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RLG10703-83516;
                                     Database=Parcial2-LibrosAsientosContables;
                                     Trusted_Connection=True;
                                     TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //LibroContable
            modelBuilder.Entity<LibroContable>().HasKey(l => l.LibroContableId);
            modelBuilder.Entity<LibroContable>().HasIndex(l => l.Codigo).IsUnique();
            modelBuilder.Entity<LibroContable>().Property(l => l.CapitalActual).HasDefaultValue(0);
            modelBuilder.Entity<LibroContable>().Property(l => l.Mes).IsRequired();
            modelBuilder.Entity<LibroContable>().Property(l => l.Año).IsRequired();

            //Concepto
            modelBuilder.Entity<Concepto>().HasKey(c => c.ConceptoId);
            modelBuilder.Entity<Concepto>().HasIndex(c => c.Codigo).IsUnique();
            modelBuilder.Entity<Concepto>().Property(c => c.Nombre).IsRequired();

            //AsientoContable
            modelBuilder.Entity<AsientoContable>().HasKey(a => a.AsientoContableId);
            modelBuilder.Entity<AsientoContable>().HasIndex(a => a.Codigo).IsUnique();
            modelBuilder.Entity<AsientoContable>().Property(a => a.Fecha).IsRequired();
            modelBuilder.Entity<AsientoContable>().Property(a => a.Tipo).IsRequired();
            modelBuilder.Entity<AsientoContable>().Property(a => a.Monto).IsRequired();
            modelBuilder.Entity<AsientoContable>().HasOne(a => a.LibroContable);
            modelBuilder.Entity<AsientoContable>().HasOne(a => a.Concepto);

        }
    }
}
