﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThiGKNguyenTuanTu_63135967.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ThiGK_63135967Entities : DbContext
    {
        public ThiGK_63135967Entities()
            : base("name=ThiGK_63135967Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CONGTY> CONGTies { get; set; }
        public DbSet<DICHVU> DICHVUs { get; set; }
    }
}
