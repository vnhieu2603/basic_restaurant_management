﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace QuanLiQuanCafe.Models
{
    public partial class QuanLyQuanCafeContext : DbContext
    {
        public QuanLyQuanCafeContext()
        {
        }

        public QuanLyQuanCafeContext(DbContextOptions<QuanLyQuanCafeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillInfo> BillInfos { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public virtual DbSet<TableFood> TableFoods { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			if (!optionsBuilder.IsConfigured)
			{
				var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
				IConfiguration con = builder.Build();
				string connect = con.GetValue<string>("ConnectionStrings:value");
				optionsBuilder.UseSqlServer(connect);
			}
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Account__C9F28457BEED7AEE");

                entity.ToTable("Account");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Kter')");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut).HasColumnType("date");

                entity.Property(e => e.IdTable).HasColumnName("idTable");

                entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");



				entity.HasOne(d => d.IdTableNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__status__36B12243");
            });

            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.ToTable("BillInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.IdBill).HasColumnName("idBill");

                entity.Property(e => e.IdFood).HasColumnName("idFood");

                entity.HasOne(d => d.IdBillNavigation)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.IdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillInfo__count__3A81B327");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillInfo__idFood__3B75D760");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Chưa đặt tên')");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Food__price__31EC6D26");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.ToTable("FoodCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Chưa đặt tên')");
            });

            modelBuilder.Entity<TableFood>(entity =>
            {
                entity.ToTable("TableFood");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Bàn chưa có tên')");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(N'Trống')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
