﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Calificacion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sistema_CalificacionEntities : DbContext
    {
        public Sistema_CalificacionEntities()
            : base("name=Sistema_CalificacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALUMNOS> ALUMNOS { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<MATRICULA> MATRICULA { get; set; }
        public virtual DbSet<NIVELES> NIVELES { get; set; }
        public virtual DbSet<NOTAS> NOTAS { get; set; }
        public virtual DbSet<PERIODOS_NOTAS> PERIODOS_NOTAS { get; set; }
        public virtual DbSet<REPRESENTANTE> REPRESENTANTE { get; set; }
    }
}
