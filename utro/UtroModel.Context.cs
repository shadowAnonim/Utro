﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace utro
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class utroEntities : DbContext
    {
        public utroEntities()
            : base("name=utroEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fabric> fabric { get; set; }
        public virtual DbSet<fabricStorage> fabricStorage { get; set; }
        public virtual DbSet<furniture> furniture { get; set; }
        public virtual DbSet<furnitureStorage> furnitureStorage { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<order_products> order_products { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<product_furnitures> product_furnitures { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<stage> stage { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}