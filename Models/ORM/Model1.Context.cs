﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.ORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PandemiaEntities : DbContext
    {
        public PandemiaEntities()
            : base("name=PandemiaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Denuncias> Denuncias { get; set; }
        public virtual DbSet<DenunciasEstado> DenunciasEstado { get; set; }
        public virtual DbSet<DonacionesInsumos> DonacionesInsumos { get; set; }
        public virtual DbSet<DonacionesMonetarias> DonacionesMonetarias { get; set; }
        public virtual DbSet<DonacionesTipo> DonacionesTipo { get; set; }
        public virtual DbSet<MotivoDenuncia> MotivoDenuncia { get; set; }
        public virtual DbSet<Necesidades> Necesidades { get; set; }
        public virtual DbSet<NecesidadesDonacionesInsumos> NecesidadesDonacionesInsumos { get; set; }
        public virtual DbSet<NecesidadesDonacionesMonetarias> NecesidadesDonacionesMonetarias { get; set; }
        public virtual DbSet<NecesidadesEstado> NecesidadesEstado { get; set; }
        public virtual DbSet<NecesidadesReferencias> NecesidadesReferencias { get; set; }
        public virtual DbSet<NecesidadesValoraciones> NecesidadesValoraciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosTipo> UsuariosTipo { get; set; }
    }
}
