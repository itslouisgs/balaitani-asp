﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace balaitani_psd.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MainDatabaseEntities : DbContext
    {
        public MainDatabaseEntities()
            : base("name=MainDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<TransactionHeader> TransactionHeaders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
