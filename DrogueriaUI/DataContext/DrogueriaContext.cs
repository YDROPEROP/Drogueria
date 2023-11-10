using System;
using System.Collections.Generic;
using DrogueriaUI.Models;
using Microsoft.EntityFrameworkCore;

namespace DrogueriaUI.DataContext;

public partial class DrogueriaContext : DbContext
{
    public DrogueriaContext()
    {
    }

    public DrogueriaContext(DbContextOptions<DrogueriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); DataBase=Drogueria;Integrated Security=true; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ciudad__3214EC07F16F597D");

            entity.ToTable("Ciudad");

            entity.Property(e => e.Nomre).HasMaxLength(50);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC07C00ADED2");

            entity.ToTable("Cliente");

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.IdCiudad).HasColumnName("Id_Ciudad");
            entity.Property(e => e.Identificacion).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK__Cliente__Id_Ciud__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
