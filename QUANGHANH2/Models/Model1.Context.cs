﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANGHANHABCEntities : DbContext
    {
        public QUANGHANHABCEntities()
            : base("name=QUANGHANHABCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acceptance> Acceptances { get; set; }
        public virtual DbSet<Category_attribute_value> Category_attribute_value { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Documentary> Documentaries { get; set; }
        public virtual DbSet<Documentary_big_maintain_details> Documentary_big_maintain_details { get; set; }
        public virtual DbSet<Documentary_Inspection_details> Documentary_Inspection_details { get; set; }
        public virtual DbSet<Documentary_liquidation_details> Documentary_liquidation_details { get; set; }
        public virtual DbSet<Documentary_maintain_details> Documentary_maintain_details { get; set; }
        public virtual DbSet<Documentary_moveline_details> Documentary_moveline_details { get; set; }
        public virtual DbSet<Documentary_repair_details> Documentary_repair_details { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Equipment_attribute> Equipment_attribute { get; set; }
        public virtual DbSet<Equipment_category> Equipment_category { get; set; }
        public virtual DbSet<Equipment_category_attribute> Equipment_category_attribute { get; set; }
        public virtual DbSet<Fuel_activities_consumption> Fuel_activities_consumption { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<Quantity_activities> Quantity_activities { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<Supply_plan> Supply_plan { get; set; }
    }
}
