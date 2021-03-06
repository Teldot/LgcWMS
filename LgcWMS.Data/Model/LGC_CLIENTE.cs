//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LGC_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LGC_CLIENTE()
        {
            this.LCG_CLIENTE_CLIENTE = new HashSet<LCG_CLIENTE_CLIENTE>();
            this.LGC_CLIENTE_PROVEEDORES = new HashSet<LGC_CLIENTE_PROVEEDORES>();
            this.ASFW_COMPANY = new HashSet<ASFW_COMPANY>();
        }
    
        public System.Guid ClienteID { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public System.DateTime FechaDiligenciamiento { get; set; }
        public Nullable<System.DateTime> FechaRadicacion { get; set; }
        public System.DateTime FechaUltimaActualizacion { get; set; }
        public int TipoPersona { get; set; }
        public string NombreRazonSocial { get; set; }
        public string NIToCC { get; set; }
        public int ClaseSociedad { get; set; }
        public string EscrituraConstitucionNo { get; set; }
        public string EscrituraConstitucionNotaria { get; set; }
        public Nullable<int> EscrituraConstitucionDe { get; set; }
        public string UltimaReformaEscrituraNo { get; set; }
        public string UltimaReformaEscrituraNotaria { get; set; }
        public Nullable<int> UltimaReformaEscrituraDe { get; set; }
        public string MatriculaCamaraComercioNo { get; set; }
        public Nullable<System.DateTime> FechaCertificado { get; set; }
        public Nullable<decimal> CapitalSocialRegistrado { get; set; }
        public string DescripcionActividadesEconomicas { get; set; }
        public string DireccionSedePrincipal { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public Nullable<int> Departamento { get; set; }
        public string TelefonoNo { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public string PaginaWeb { get; set; }
        public Nullable<int> Regimen { get; set; }
        public Nullable<bool> GranContribuyente { get; set; }
        public Nullable<bool> RegimenComun { get; set; }
        public Nullable<bool> Autoretencion { get; set; }
        public string NoResolucion { get; set; }
        public Nullable<System.DateTime> FechaResolucion { get; set; }
        public Nullable<int> ReferenciaBancariaBanco { get; set; }
        public string ReferenciaBancariaNoCuenta { get; set; }
        public Nullable<int> ReferenciaBancariaTipoCuenta { get; set; }
        public string ReferenciaBancariaSucursal { get; set; }
        public string ReferencuaBancariaTelefono { get; set; }
        public bool VerificacionListaClinton { get; set; }
        public Nullable<System.DateTime> VerificacionListaClintonFecha { get; set; }
        public bool VerificaionReferencias { get; set; }
        public Nullable<System.DateTime> VerificacionReferenciasFecha { get; set; }
        public bool Activo { get; set; }
        public string DescripcionMercanciaTramite { get; set; }
        public Nullable<int> EscrituraConstitucionDepDe { get; set; }
        public Nullable<int> UltimaReformaEscrituraDepDe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LCG_CLIENTE_CLIENTE> LCG_CLIENTE_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LGC_CLIENTE_PROVEEDORES> LGC_CLIENTE_PROVEEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASFW_COMPANY> ASFW_COMPANY { get; set; }
    }
}
