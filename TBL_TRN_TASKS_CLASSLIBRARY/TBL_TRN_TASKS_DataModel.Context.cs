﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TBL_TRN_TASKS_CLASSLIBRARY
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EasyLivingEntities : DbContext
    {
        public EasyLivingEntities()
            : base("name=EasyLivingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_TRN_TASKS> TBL_TRN_TASKS { get; set; }
        public virtual DbSet<TBL_TRN_USER> TBL_TRN_USER { get; set; }
    }
}