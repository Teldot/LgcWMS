using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Data.Entities
{
    public class GUIA_LABEL_DUO
    {
        public string GUIA_PREFIJO1 { get; set; }
        public long GUIA_ID1 { get; set; }
        public string NOMBRE1 { get; set; }
        public string DIRECCION1 { get; set; }
        public string TELEFONO1 { get; set; }
        public string CIUDAD1 { get; set; }
        public string REFERENCIA1 { get; set; }
        public string CONSECUTIVO_CLIENTE1 { get; set; }
        public byte[] BARCODE1 { get; set; }
        public string GUIA_PREFIJO2 { get; set; }
        public long GUIA_ID2 { get; set; }
        public string NOMBRE2 { get; set; }
        public string DIRECCION2 { get; set; }
        public string TELEFONO2 { get; set; }
        public string CIUDAD2 { get; set; }
        public string REFERENCIA2 { get; set; }
        public string CONSECUTIVO_CLIENTE2 { get; set; }
        public byte[] BARCODE2 { get; set; }
    }
}
