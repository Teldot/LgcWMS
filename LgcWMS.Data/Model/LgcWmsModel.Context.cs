﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LgcWMS.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class LgcWebEntities : DbContext
    {
        public LgcWebEntities()
            : base("name=LgcWebEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<ASFW_CATTYPE> ASFW_CATTYPE { get; set; }
        public virtual DbSet<LCG_CLIENTE_CLIENTE> LCG_CLIENTE_CLIENTE { get; set; }
        public virtual DbSet<LGC_CLIENTE> LGC_CLIENTE { get; set; }
        public virtual DbSet<LGC_CLIENTE_PROVEEDORES> LGC_CLIENTE_PROVEEDORES { get; set; }
        public virtual DbSet<LGC_RECOLECCION_ITEM> LGC_RECOLECCION_ITEM { get; set; }
        public virtual DbSet<ASFW_USER> ASFW_USER { get; set; }
        public virtual DbSet<ASFW_ACTIVESESSION> ASFW_ACTIVESESSION { get; set; }
        public virtual DbSet<ASFW_COMPANY> ASFW_COMPANY { get; set; }
        public virtual DbSet<V_ASFW_CITY_CODE_MUN> V_ASFW_CITY_CODE_MUN { get; set; }
        public virtual DbSet<V_ASFW_CATTYPE> V_ASFW_CATTYPE { get; set; }
        public virtual DbSet<V_ASFW_CATVAL> V_ASFW_CATVAL { get; set; }
        public virtual DbSet<V_ASFW_CITY_CODE_DEP> V_ASFW_CITY_CODE_DEP { get; set; }
        public virtual DbSet<LGC_RECOLECCION> LGC_RECOLECCION { get; set; }
        public virtual DbSet<LGC_DESPACHO> LGC_DESPACHO { get; set; }
        public virtual DbSet<LGC_GUIA> LGC_GUIA { get; set; }
        public virtual DbSet<V_GUIA> V_GUIA { get; set; }
        public virtual DbSet<V_GUIA_ETIQUETA> V_GUIA_ETIQUETA { get; set; }
        public virtual DbSet<V_LGC_DESPACHO> V_LGC_DESPACHO { get; set; }
        public virtual DbSet<V_LGC_DESPACHO_GRID> V_LGC_DESPACHO_GRID { get; set; }
    }
}
