﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMPrac1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBPrac1Entities : DbContext
    {
        public DBPrac1Entities()
            : base("name=DBPrac1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<ALUMNO> ALUMNO { get; set; }
        public virtual DbSet<APODERADO> APODERADO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<INSCRITO> INSCRITO { get; set; }
    }
}
