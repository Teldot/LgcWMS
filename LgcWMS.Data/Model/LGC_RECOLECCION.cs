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
    
    public partial class LGC_RECOLECCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LGC_RECOLECCION()
        {
            this.LGC_RECOLECCION_ITEM = new HashSet<LGC_RECOLECCION_ITEM>();
            this.LGC_GUIA = new HashSet<LGC_GUIA>();
        }
    
        public long RECOLECCION_ID { get; set; }
        public string CONSECUTIVO { get; set; }
        public string CONSECUTIVO_AVMK { get; set; }
        public string CONSECUTIVO_CLIENTE { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public int CLIENTE_ID { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public int CIUDAD { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string DETALLE { get; set; }
        public int CANTIDAD { get; set; }
    
        public virtual ASFW_COMPANY ASFW_COMPANY { get; set; }
        public virtual LGC_CLIENTE_PROVEEDORES LGC_CLIENTE_PROVEEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LGC_RECOLECCION_ITEM> LGC_RECOLECCION_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LGC_GUIA> LGC_GUIA { get; set; }
    }
}
