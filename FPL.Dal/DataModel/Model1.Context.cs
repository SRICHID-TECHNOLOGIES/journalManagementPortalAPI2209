﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPL.Dal.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JournalManagementPortalEntities : DbContext
    {
        public JournalManagementPortalEntities()
            : base("name=JournalManagementPortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Manuscript_Table> Manuscript_Table { get; set; }
        public virtual DbSet<ManuscriptSub> ManuscriptSubs { get; set; }
        public virtual DbSet<Register_Table> Register_Table { get; set; }
        public virtual DbSet<subjectcontent_Table> subjectcontent_Table { get; set; }
    }
}
