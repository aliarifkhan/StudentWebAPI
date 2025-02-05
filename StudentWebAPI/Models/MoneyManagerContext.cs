using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentWebAPI.Models;

public partial class MoneyManagerContext : DbContext
{
    public MoneyManagerContext()
    {
    }

    public MoneyManagerContext(DbContextOptions<MoneyManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Expence> Expences { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=ALEE; database=MoneyManager; trusted_connection=true; trustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Expence");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Drinks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Education).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Food).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fuel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hostal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Medicine).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Others).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pets).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RemainingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sum).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tips).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK__Expence__ID__3F466844");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Profile__3214EC277D0AAA37");

            entity.ToTable("Profile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Discription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Income).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nmae)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
