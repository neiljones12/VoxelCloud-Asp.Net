﻿using System.Data.Entity;
using VoxelCloud.Models.Tables;

namespace VoxelCloud.Models
{
    public class Context : DbContext
    {
        public Context() : base("name = database") { }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Location> Location { get; set; } 
        public virtual DbSet<CustomerLocation> CustomerLocation { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductEvent> ProductEvent { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProduct { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}