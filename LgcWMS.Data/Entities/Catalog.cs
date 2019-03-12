using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Data.Entities
{
    public class Catalog
    {

    }

    public enum Profiles
    {
        MASTER_ADMIN = 1,
        LGC_AUX_LOG = 2,
        LGC_COMER = 3,
        LGC_EJEC_CUE = 4,
        CTR_GERENCIA = 5,
        CTR_JEFE_TEC = 6,
        CTR_AUX_LOG = 7,
        CTR_JEFE_LOG = 8,
        CTR_COMER = 9
    }

    /// <summary>
    /// CATALOG TYPES
    /// </summary>
    public enum CatTypes
    {
        TIPO_IDENTIFICACION = 2,
        ACTIVIDAD_ECONOMICA = 12,
        FORMA_PAGO = 13,
        MOVIMIENTO = 14,
        DIRECTORIO = 18,
        ESTADO_HISTORIAL = 19,
        TIPO_PERSONA = 20,
        TIPO_CUENTA_BANCARIA = 21,
        TIPO_CONTACTO = 22,
        HORARIO_RECOLECCION = 23,
        UNIDAD_MEDIDA = 24,
        TIPOS_EMPAQUE = 25,
        DISPERSION = 26,
        TIPOS_EMPAQUE_MENS = 28,
        TIPOS_VEHICULO = 29,
        REGIMEN = 30,
        BANCO = 32,
        TRANSPORTADORA = 33,
        CLASE_SOCIEDAD = 34,
        CIUDAD = 35,
        DEPARTAMENTO = 36,
        TIPO_SERVICIO = 37,
        TIPO_PROD_O_SERV = 38,
        AREA_LOGISTIC = 39,
        TIPO_TRAYECTO = 40,
        TIPO_POBLACION = 41,
        TIPO_COD_CIUDAD = 42
    }

    public enum CatTipoProdServ
    {
        AUDITORIA_ISO_90012015 = 1470,
        EXAMEN_VISUAL = 1469,
        EXAMENES_OCUPACIONALES = 1468,
        PAPELERIA = 1467,
        SOFTWARE = 1476,
        TRANSPORTE_MERCANCIA = 1466
    }

    /// <summary>
    /// CAT: MOVIMIENTO = 14
    /// </summary>
    public enum CatMovimiento
    {
        INGRESO = 75,
        EGRESO = 76
    }

    public enum CatTipoContacto
    {
        CONTACTO = 193,
        CONTACTO_PRINCIPAL = 187,
        FIRMAS_AUTORIZADAS = 190,
        REFERENCIA_BANCARIA = 191,
        REFERENCIA_COMERCIAL = 192,
        REPRESENTANTE_LEGAL = 189,
        SOCIOS = 188
    }

    public enum CatTipoTrayecto
    {
        RURAL = 1488,
        URBANO = 1489
    }

    public enum CatTipoServicio
    {
        MENSAJERIA = 1461,
        PAQUETEO = 1462,
        MERCANCIA = 1463,
        RADICACION_DOCUMENTOS = 1464,
        CARGA_AEREA = 1465
    }

    public enum CatTipoGuia
    {
        Recogida = 1512,
        Despacho = 1513
    }

}
