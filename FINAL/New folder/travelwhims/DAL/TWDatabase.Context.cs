﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TWDatabaseEntities : DbContext
    {
        public TWDatabaseEntities()
            : base("name=TWDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blogcomment> Blogcomments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CustomerPackage> CustomerPackages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TravelAgency> TravelAgencies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
