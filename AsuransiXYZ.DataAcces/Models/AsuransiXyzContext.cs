using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AsuransiXYZ.DataAcces.Models;

public partial class AsuransiXyzContext : DbContext
{
    public AsuransiXyzContext()
    {
    }

    public AsuransiXyzContext(DbContextOptions<AsuransiXyzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IuranProduct> IuranProducts { get; set; }

    public virtual DbSet<JenisProduct> JenisProducts { get; set; }

    public virtual DbSet<Kendaraan> Kendaraans { get; set; }

    public virtual DbSet<KetentuanProduct> KetentuanProducts { get; set; }

    public virtual DbSet<Nasabah> Nasabahs { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PoliceAnsuransi> PoliceAnsuransis { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Prospect> Prospects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-J9DU5J54; Database=AsuransiXYZ; user=sa; password=indocyber; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IuranProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IuranPro__3214EC0786B06D1F");

            entity.ToTable("IuranProduct");

            entity.Property(e => e.Kendaraan).HasColumnType("money");
            entity.Property(e => e.OverTwenty).HasColumnType("money");
            entity.Property(e => e.UnderTwenty).HasColumnType("money");
        });

        modelBuilder.Entity<JenisProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JenisPro__3214EC078A80623A");

            entity.ToTable("JenisProduct");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kendaraan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kendaraa__3214EC07BE485B17");

            entity.ToTable("Kendaraan");

            entity.Property(e => e.IdNasabah)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JenisKendaraan)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Merek)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoPolisi)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NoStnk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NoSTNK");
            entity.Property(e => e.Warna)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNasabahNavigation).WithMany(p => p.Kendaraans)
                .HasForeignKey(d => d.IdNasabah)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Kendaraan__IdNas__3E52440B");
        });

        modelBuilder.Entity<KetentuanProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ketentua__3214EC07BA0C0D3F");

            entity.ToTable("KetentuanProduct");

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nasabah>(entity =>
        {
            entity.HasKey(e => e.IdNasabah);

            entity.ToTable("Nasabah");

            entity.HasIndex(e => e.IdProspect, "FK_Nasabah").IsUnique();

            entity.Property(e => e.IdNasabah)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoKtp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusKk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StatusKK");

            entity.HasOne(d => d.IdProspectNavigation).WithOne(p => p.Nasabah)
                .HasForeignKey<Nasabah>(d => d.IdProspect)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Nasabah__IdProsp__286302EC");

            entity.HasOne(d => d.PaymentCodeNavigation).WithMany(p => p.Nasabahs)
                .HasForeignKey(d => d.PaymentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Nasabah__Payment__276EDEB3");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PoliceAnsuransi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PoliceAn__3214EC07E4B59C7C");

            entity.ToTable("PoliceAnsuransi");

            entity.Property(e => e.NasabahTertanggung)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pemilik)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.KendaraanTertanggungNavigation).WithMany(p => p.PoliceAnsuransis)
                .HasForeignKey(d => d.KendaraanTertanggung)
                .HasConstraintName("FK__PoliceAns__Kenda__440B1D61");

            entity.HasOne(d => d.NasabahTertanggungNavigation).WithMany(p => p.PoliceAnsuransiNasabahTertanggungNavigations)
                .HasForeignKey(d => d.NasabahTertanggung)
                .HasConstraintName("FK__PoliceAns__Nasab__4316F928");

            entity.HasOne(d => d.PemilikNavigation).WithMany(p => p.PoliceAnsuransiPemilikNavigations)
                .HasForeignKey(d => d.Pemilik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PoliceAns__Pemil__4222D4EF");

            entity.HasOne(d => d.Product).WithMany(p => p.PoliceAnsuransis)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PoliceAns__Produ__412EB0B6");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Product__2E8946D4A741DEF8");

            entity.ToTable("Product");

            entity.Property(e => e.Frekuensi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Manfaat)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Iuran).WithMany(p => p.Products)
                .HasForeignKey(d => d.IuranId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__IuranId__398D8EEE");

            entity.HasOne(d => d.JenisNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Jenis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__Jenis__3B75D760");

            entity.HasOne(d => d.Ketentuan).WithMany(p => p.Products)
                .HasForeignKey(d => d.KetentuanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__Ketentu__3A81B327");
        });

        modelBuilder.Entity<Prospect>(entity =>
        {
            entity.HasKey(e => e.IdProspect).HasName("PK__Prospect__C7BD7CD61C6B6317");

            entity.ToTable("Prospect");

            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pekerjaan)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
