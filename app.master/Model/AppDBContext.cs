﻿using app.master.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.master.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("appDB")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDBContext, Migration.Configuration>("AppDBConnectionString"));
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<FileAttach> FileAttach { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            # region Product
            modelBuilder.Entity<Product>()
                .HasMany(p => p.FileAttaches)
                .WithOptional(p => p.Product);
            modelBuilder.Entity<Product>()
                .Property(x => x.Name)
                .HasMaxLength(55)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(x => x.Code)
                .HasMaxLength(7)
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.QuantityPerUnit)
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.UnitPrice)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(x => x.UnitOrders)
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            #endregion

            #region Order
            modelBuilder.Entity<Order>()
                .Property(x => x.OrderDate)
                .HasColumnType("datetime2")
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(x => x.ShippedDate)
                .HasColumnType("datetime2")
               .IsOptional();
            modelBuilder.Entity<Order>()
                .Property(x => x.ShipAdress)
                .HasMaxLength(150)
                .HasColumnType("text")
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(x => x.ShipVia)
                .IsOptional();
            modelBuilder.Entity<Order>()
                .Property(x => x.State)
                .IsOptional();
            modelBuilder.Entity<Order>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Order>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Order>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            #endregion

            #region OrderProduct
            modelBuilder.Entity<OrderProduct>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<OrderProduct>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<OrderProduct>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.OrderId, x.ProductId });
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Category>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<Category>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            #endregion

            #region ProductCategory
            modelBuilder.Entity<ProductCategory>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<ProductCategory>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<ProductCategory>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<ProductCategory>()
                .HasKey(x => new { x.CategoryId, x.ProductId });
            #endregion

            #region FileAttach
            modelBuilder.Entity<FileAttach>()
                .HasOptional(f => f.Product)
                .WithMany(f => f.FileAttaches);
            modelBuilder.Entity<FileAttach>()
                .Property(x => x.Path)
                .IsRequired();
            modelBuilder.Entity<FileAttach>()
                .Property(x => x.CreationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<FileAttach>()
                .Property(x => x.LastModificationTime)
                .HasColumnType("datetime2")
                .IsOptional();
            modelBuilder.Entity<FileAttach>()
                .Property(x => x.DeletionTime)
                .HasColumnType("datetime2")
                .IsOptional();
            #endregion
        }
    }
}
