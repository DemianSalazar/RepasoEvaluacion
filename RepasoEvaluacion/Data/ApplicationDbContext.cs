using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepasoEvaluacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepasoEvaluacion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Socio> Socios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK__Cuenta__7E532BC7D4A31E49");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSocio)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoTotal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoSocioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.CodigoSocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Socio");
            });

            modelBuilder.Entity<Socio>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PK__Socio__B4ADFE39B5A94227");

                entity.ToTable("Socio");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
