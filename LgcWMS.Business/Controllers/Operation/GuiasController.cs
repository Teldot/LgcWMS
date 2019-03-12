using AS.FW.Controller;
using AS.FW.Model;
using LgcWMS.Business.Controllers.Catalogs;
using LgcWMS.Data.Entities;
using LgcWMS.Data.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.Controllers.Operation
{
    public class GuiasController : GeneralController
    {
        #region Attributes
        const string SQL_GET_CONSECT = "SELECT 0 catId, CONSECUTIVO_CLIENTE catVal FROM V_LGC_DESPACHO WHERE DATEDIFF(DAY,FECHA_ENVIO_ARCHIVO,GETDATE())<10 ORDER BY CONSECUTIVO_CLIENTE;";
        const string SQL_GET_PROVE = "SELECT PROVEEDOR_ID catId, NOMBRE catVal FROM V_LGC_CLIENTE_PROVEEDORES ORDER BY NOMBRE;";
        const string SQL_GET_GRIDGUIA = "SELECT  GUIA_ID, GUIA, CONSECUTIVO_CLIENTE, CONSECUTIVO, CODIGO_PREMIO, PREMIO, FECHA_REDENCION, REMITENTE_NOMBRE, REMITENTE_VAL, REMITENTE_DIRECCION, ORIGEN_ID, ORIGEN, DESTINATARIO_NOMBRE, DESTINATARIO_DIRECCION, DESTINATARIO_TELEFONO, DESTINO_ID, DESTINO, UNIDADES, VALOR FROM V_LGC_DESPACHO_GRID";
        const string SQL_WHERE_CONS = "WHERE CONSECUTIVO_CLIENTE = '{0}'";
        const string SQL_WHERE_PROV = "WHERE PROVEEDOR_ID = {0}";
        const string SQL_IN_GUIA = "INSERT INTO LGC_GUIA (GUIA_ID,GUIA_PREFIJO,TIPO_ID,RECOLECCION_ID,DESPACHO_ID,ORIGEN,REMITENTE_NOMBRE,REMITENTE_DIRECCION,REMITENTE_TELEFONO,DESTINO,DESTINATARIO_NOMBRE,DESTINATARIO_DIRECCION,DESTINATARIO_TELEFONO,FECHA_ENVIO,UNIDADES,PESO,PESO_VOL,PESO_LIQ,VALOR_DECLARADO,DICE_CONTENER,ELABORADO_POR,OBSERVACIONES) VALUES ({0},'{1}',{2},{3},{4},{5},'{6}','{7}','{8}',{9},'{10}','{11}','{12}',GETDATE(),{13},{14},{15},{16},{17},'{18}',{19},'{20}');";
        #endregion
        #region Properties
        LgcWebEntities Entities;
        public DataTable DtDespachos { get; set; }
        #endregion
        #region Contructor
        public GuiasController()
        {
            Entities = new LgcWebEntities();
            RequestObj = new TransObj();
        }
        #endregion
        #region Override Methods
        public override object GetData(int actionType)
        {
            //return base.GetData(actionType);
            ResponseObj = new TransObj();
            string consec;
            int prvId;
            try
            {
                switch ((ActionType)actionType)
                {
                    case ActionType.GetConsec:
                        var clts = Entities.Database.SqlQuery<GeneralCat>(SQL_GET_CONSECT).ToList();
                        clts.Insert(0, new GeneralCat { catId = -1, catVal = "Seleccione..." });

                        return clts;
                    case ActionType.GetFecha:
                        break;
                    case ActionType.GetProveedor:
                        #region GetProveedor
                        var prov = Entities.Database.SqlQuery<GeneralCat>(SQL_GET_PROVE).ToList();
                        prov.Insert(0, new GeneralCat { catId = -1, catVal = "Seleccione..." });

                        return prov;
                    #endregion
                    case ActionType.GetDespachoByConsec:
                        #region GetDespachoByConsec
                        consec = RequestObj.TransParms.Where(p => p.Key == "consec").FirstOrDefault().Value;
                        var despByCon = (from d in Entities.V_LGC_DESPACHO_GRID
                                         where d.CONSECUTIVO_CLIENTE == consec
                                         select new { d.GUIA_ID, d.GUIA, d.CONSECUTIVO_CLIENTE, d.CONSECUTIVO, d.CODIGO_PREMIO, d.PREMIO, d.FECHA_REDENCION, d.REMITENTE_NOMBRE, d.REMITENTE_VAL, d.REMITENTE_DIRECCION, d.ORIGEN_ID, d.ORIGEN, d.DESTINATARIO_NOMBRE, d.DESTINATARIO_DIRECCION, d.DESTINATARIO_TELEFONO, d.DESTINO_ID, d.DESTINO, d.UNIDADES, d.VALOR }).ToList();

                        return despByCon;
                    #endregion
                    case ActionType.GetDespachoByFecha:
                        break;
                    case ActionType.GetDespachoByProveedor:
                        #region GetDespachoByProveedor
                        prvId = int.Parse(RequestObj.TransParms.Where(p => p.Key == "prvId").FirstOrDefault().Value);
                        var despByProv = (from d in Entities.V_LGC_DESPACHO_GRID
                                          where d.PROVEEDOR_ID == prvId
                                          select new { d.GUIA_ID, d.GUIA, d.CONSECUTIVO_CLIENTE, d.CONSECUTIVO, d.CODIGO_PREMIO, d.PREMIO, d.FECHA_REDENCION, d.REMITENTE_NOMBRE, d.REMITENTE_VAL, d.REMITENTE_DIRECCION, d.ORIGEN_ID, d.ORIGEN, d.DESTINATARIO_NOMBRE, d.DESTINATARIO_DIRECCION, d.DESTINATARIO_TELEFONO, d.DESTINO_ID, d.DESTINO, d.UNIDADES, d.VALOR })
                                          .OrderBy(d => d.CONSECUTIVO_CLIENTE).ToList();
                        return despByProv;
                    #endregion
                    case ActionType.SaveData:
                        var data = JsonConvert.DeserializeObject<JObject>(RequestObj.TransParms.Where(p => p.Key == "data").FirstOrDefault().Value);
                        var NoGuia = long.Parse(RequestObj.TransParms.Where(p => p.Key == "NoGuia").FirstOrDefault().Value);
                        var fEnvio = RequestObj.TransParms.Where(p => p.Key == "fEnvio").FirstOrDefault().Value;
                        var peso = RequestObj.TransParms.Where(p => p.Key == "peso").FirstOrDefault().Value;
                        var pesoVol = RequestObj.TransParms.Where(p => p.Key == "pesoVol").FirstOrDefault().Value;
                        var pesoLiq = RequestObj.TransParms.Where(p => p.Key == "pesoLiq").FirstOrDefault().Value;
                        var obs = RequestObj.TransParms.Where(p => p.Key == "obs").FirstOrDefault().Value;
                        var usId = RequestObj.TransParms.Where(p => p.Key == "usId").FirstOrDefault().Value;

                        string sql = string.Format(SQL_IN_GUIA,
                                                        NoGuia, //GUIA_ID 
"LOG", //GUIA_PREFIJO 
(int)CatTipoGuia.Despacho, //TIPO_ID 
"NULL", //recoleccion  //idRECOLECCION_ID 
"NULL", //Despacho  //IdDESPACHO_ID 
data["ORIGEN_ID"], //ORIGEN 
data["REMITENTE_VAL"], //REMITENTE_NOMBRE 
data["REMITENTE_DIRECCION"], //REMITENTE_DIRECCION 
data["REMITENTE_TELEFONO"], //REMITENTE_TELEFONO 
data["DESTINO_ID"], //DESTINO 
data["DESTINATARIO_NOMBRE"], //DESTINATARIO_NOMBRE 
data["DESTINATARIO_DIRECCION"], //DESTINATARIO_DIRECCION 
data["DESTINATARIO_TELEFONO"], //DESTINATARIO_TELEFONO 
data["UNIDADES"], //UNIDADES 
peso, //PESO 
pesoVol, //PESO_VOL 
pesoLiq, //PESO_LIQ 
data["VALOR"], //VALOR_DECLARADO 
"Obsequio",//data["DICE_CONTENER"], //DICE_CONTENER 
usId, //ELABORADO_POR 
"NULL", //ENCARGADO_A 
 obs//OBSERVACIONES
                            );

                        int res = Entities.Database.ExecuteSqlCommand(sql);
                        if (res == 0)
                            throw new Exception("Los datos no han sido guardados");
                        var sGuia = (from g in Entities.LGC_GUIA
                                     where g.GUIA_ID == NoGuia
                                     select g).FirstOrDefault();
                        ResponseObj.TransParms.Add(new TransParm("sGuia", JsonConvert.SerializeObject(sGuia)));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ResponseObj;
        }
        #endregion
        #region Methods

        #endregion
        #region Enums
        public enum ActionType
        {
            GetConsec,
            GetFecha,
            GetProveedor,
            GetDespachoByConsec,
            GetDespachoByFecha,
            GetDespachoByProveedor,
            SaveData
        }
        #endregion
    }
}
