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
    
    public partial class LGC_DESPACHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LGC_DESPACHO()
        {
            this.LGC_GUIA1 = new HashSet<LGC_GUIA>();
        }
    
        public long DESPACHO_ID { get; set; }
        public int REMITENTE { get; set; }
        public string CONSECUTIVO { get; set; }
        public string CONSECUTIVO_AVMK { get; set; }
        public string CONSECUTIVO_CLIENTE { get; set; }
        public Nullable<System.DateTime> FECHA_ENVIO_ARCHIVO { get; set; }
        public string MES { get; set; }
        public Nullable<int> ANO { get; set; }
        public Nullable<System.DateTime> FECHA_REDENCION { get; set; }
        public string CEDULA { get; set; }
        public string DESTINATARIO { get; set; }
        public string ENTREGAR_A { get; set; }
        public string DIRECCION { get; set; }
        public int CIUDAD { get; set; }
        public int DEPARTAMENTO { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string CODIGO_PREMIO { get; set; }
        public string PREMIO { get; set; }
        public string ESPECIFICACIONES { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public int CANTIDAD { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public Nullable<long> GUIA_ID { get; set; }
        public int COMPANYID { get; set; }
    
        public virtual LGC_CLIENTE_PROVEEDORES LGC_CLIENTE_PROVEEDORES { get; set; }
        public virtual LGC_GUIA LGC_GUIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LGC_GUIA> LGC_GUIA1 { get; set; }
        public virtual ASFW_COMPANY ASFW_COMPANY { get; set; }
    }
}
