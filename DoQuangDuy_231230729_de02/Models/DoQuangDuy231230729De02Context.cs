using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DoQuangDuy_231230729_de02.Models;

public partial class DoQuangDuy231230729De02Context : DbContext
{
    public DoQuangDuy231230729De02Context()
    {
    }

    public DoQuangDuy231230729De02Context(DbContextOptions<DoQuangDuy231230729De02Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DqdCatalog> DqdCatalogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DoQuangDuy_231230729_de02;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DqdCatalog>(entity =>
        {
            entity.HasKey(e => e.DqdId).HasName("PK__dqdCatal__1678D967AA7363CA");

            entity.ToTable("dqdCatalog");

            entity.Property(e => e.DqdId).HasColumnName("dqdId");
            entity.Property(e => e.DqdCateActive).HasColumnName("dqdCateActive");
            entity.Property(e => e.DqdCateName)
                .HasMaxLength(200)
                .HasColumnName("dqdCateName");
            entity.Property(e => e.DqdCatePrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("dqdCatePrice");
            entity.Property(e => e.DqdCateQty).HasColumnName("dqdCateQty");
            entity.Property(e => e.DqdPicture)
                .HasMaxLength(500)
                .HasColumnName("dqdPicture");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
