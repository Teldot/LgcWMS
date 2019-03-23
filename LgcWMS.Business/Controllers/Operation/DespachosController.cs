using AS.FW.Controller;
using AS.FW.Model;
using AS.FW.Utils;
using LgcWMS.Data.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using LgcWMS.Business.Controllers.Catalogs;

namespace LgcWMS.Business.Controllers.Operation
{
    public class DespachosController : GeneralController
    {
        #region Attributes

        const string SQL_GET_CLIENTES = "SELECT COMPANYID catId, NOMBRERAZONSOCIAL catVal, CLIENTEID  FROM V_LGC_CLIENTE WHERE ACTIVO = 1 ORDER BY NOMBRERAZONSOCIAL;";
        const string SQL_IN_DESPACHO = @"INSERT INTO LGC_DESPACHO (REMITENTE,CONSECUTIVO,CONSECUTIVO_AVMK,CONSECUTIVO_CLIENTE,FECHA_ENVIO_ARCHIVO,MES,ANO,FECHA_REDENCION,CEDULA,DESTINATARIO,ENTREGAR_A,DIRECCION,CIUDAD,DEPARTAMENTO,TELEFONO,CELULAR,CORREO_ELECTRONICO,CODIGO_PREMIO,PREMIO,ESPECIFICACIONES,PROVEEDOR_ID,CANTIDAD,VALOR,COMPANYID)
VALUES({0},'{1}','{2}','{3}',convert(date,'{4}',103),NULL,NULL,convert(date,'{7}',103),{8},'{9}','{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}','{19}',{20},{21},{22},{23});
";
        const string SQL_CIUDADES = "SELECT V.ID catId, C.NOMBRES catVal FROM V_ASFW_CITY_CODE V INNER JOIN ASFW_CITY_CODE C ON V.ID = C.ID";
        const string SQL_PROVEEDORES = "SELECT PROVEEDOR_ID catId, NOMBRE catVal FROM LGC_CLIENTE_PROVEEDORES P INNER JOIN ASFW_COMPANY C ON P.CLIENTEID = C.CLIENT_ID WHERE C.COMPANYID = {0};";
        const string SQL_IS_IN_DESPACHO = "SELECT CONSECUTIVO_CLIENTE FROM LGC_DESPACHO WHERE COMPANYID = {0} ORDER BY CONSECUTIVO_CLIENTE ";
        #region Column Indexes
        public const string GV_COL_CIUDAD = "Ciudad";
        public const string GV_COL_DEPARTAMENTO = "Departamento";
        public const string GV_COL_PROVEEDOR = "Nombre_Proveedor";

        public const string GV_COL_CONSECUTIVO = "Consecutivo";
        public const string GV_COL_CONSECUTVO_AVMK = "Consecutvo_AVMK";
        public const string GV_COL_CONSECUTIVO_CLIENTE = "Consecutivo_Cliente";
        public const string GV_COL_FECHA_ENVIO_ARCHIVO = "Fecha_Envio_Archivo";
        public const string GV_COL_FECHA_DE_REDENCION = "Fecha_de_Redencion";
        public const string GV_COL_CEDULA = "Cedula";

        public const string GV_COL_CLIENTE = "Cliente";
        public const string GV_COL_ENTREGAR_A = "Entregar_a";
        public const string GV_COL_DIRECCION = "Direccion";
        public const string GV_COL_TELEFONO = "Teléfono";
        public const string GV_COL_CELULAR = "Celular";
        public const string GV_COL_CORREO_ELECTRONICO = "Correo_Electronico";
        public const string GV_COL_CODIGO_PREMIO = "Codigo_Premio";
        public const string GV_COL_PREMIO = "Premio";
        public const string GV_COL_ESPECIFICACIONES = "Especificaciones";
        public const string GV_COL_NOMBRE_PROVEEDOR = "Nombre_Proveedor";
        public const string GV_COL_CODIGO_PROVEEDOR = "Codigo_Proveedor";
        public const string GV_COL_CANTIDAD = "Cantidad";
        public const string GV_COL_VALOR = "Valor";
        public const string GV_COL_TRANSPORTADOR = "Transportador";


        public const int COL_CONSECUTIVO = 0;
        public const int COL_CONSECUTIVO_AVMK = 1;
        public const int COL_CONSECUTIVO_CLIENTE = 2;
        public const int COL_FECHA_ENVIO_ARCHIVO = 3;
        public const int COL_MES = 4;
        public const int COL_AÑO = 5;
        public const int COL_FECHA_REDENCION = 6;
        public const int COL_CEDULA = 7;
        public const int COL_DESTINATARIO = 8;
        public const int COL_ENTREGAR_A = 9;
        public const int COL_DIRECCION = 10;
        public const int COL_CIUDAD = 11;
        public const int COL_DEPARTAMENTO = 12;
        public const int COL_TELEFONO = 13;
        public const int COL_CELULAR = 14;
        public const int COL_CORREO_ELECTRONICO = 15;
        public const int COL_CODIGO_PREMIO = 16;
        public const int COL_PREMIO = 17;
        public const int COL_ESPECIFICACIONES = 18;
        public const int COL_PROVEEDOR_ID = 19;
        public const int COL_COD_PROVEEDOR = 20;
        public const int COL_CANTIDAD = 21;
        public const int COL_VALOR = 22;
        #endregion
        #endregion
        #region Properties
        LgcWebEntities Entities;
        public DataTable DtDespachosIn { get; set; }
        public DataTable DtDespachosOut { get; set; }
        public List<GeneralCat> Deptos { get; set; }
        public List<GeneralCat> CitiesFullNames { get; set; }
        public List<GeneralCat> CitiesDeptos { get; set; }
        public List<GeneralCat> Proveedores { get; set; }
        public List<string> ConsecCliente { get; set; }
        public int ClienteID { get; set; }
        #endregion
        #region Constructor
        public DespachosController()
        {
            Entities = new LgcWebEntities();
        }
        #endregion
        #region Override Methods
        public override object GetData(int actionType)
        {
            //return base.GetData(actionType);
            ResponseObj = new TransObj();
            StringBuilder sql;
            ExcelLoader exLoader;
            string path;
            int cat, i = 0;
            try
            {
                switch ((ActionType)actionType)
                {
                    case ActionType.GetCatalog:
                        #region GetCatalog
                        GeneralController catController = new CatalogsController();
                        //cat = int.Parse(RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        catController.RequestObj = this.RequestObj;
                        return catController.GetData((int)CatalogsController.ActionType.GetCatalog);
                    #endregion
                    case ActionType.GetWorksheets:
                        #region GetWorksheets
                        path = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "fName").FirstOrDefault().Value);
                        exLoader = new ExcelLoader();
                        return exLoader.LoadWorkSheets(path);
                    #endregion
                    case ActionType.ImportDespachos:
                        #region ImportDespachos
                        path = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "fName").FirstOrDefault().Value);
                        string workSheet = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "workSheet").FirstOrDefault().Value);
                        exLoader = new ExcelLoader();
                        DtDespachosIn = exLoader.LoadFile(path, workSheet);
                        return true;
                    #endregion
                    case ActionType.LoadRemitente:
                        #region LoadRemitente
                        var clts = Entities.Database.SqlQuery<GeneralCat>(SQL_GET_CLIENTES).ToList();
                        clts.Insert(0, new GeneralCat { catId = -1, catVal = "Seleccione..." });

                        return clts;
                    #endregion
                    case ActionType.LoadCitiesFullName:
                        #region LoadCitiesFullName
                        CitiesFullNames = Entities.Database.SqlQuery<GeneralCat>(SQL_CIUDADES).ToList();
                        #endregion
                        break;
                    case ActionType.LoadProveedores:
                        #region LoadProveedores
                        Proveedores = Entities.Database.SqlQuery<GeneralCat>(string.Format(SQL_PROVEEDORES, ClienteID)).ToList();
                        #endregion
                        break;
                    case ActionType.IsInDespacho:
                        #region IsInDespacho
                        ConsecCliente = Entities.Database.SqlQuery<string>(SQL_IS_IN_DESPACHO, ClienteID).ToList();
                        #endregion
                        break;
                    case ActionType.InsertDespachos:
                        #region InsertDespachos
                        //int cId = JsonConvert.DeserializeObject<int>(RequestObj.TransParms.Where(p => p.Key == "cId").FirstOrDefault().Value);
                        DataRow r = null;
                        sql = new StringBuilder();
                        string s = "", conCliente = "";
                        try
                        {
                            for (i = 0; i < DtDespachosOut.Rows.Count; i++)
                            {
                                r = DtDespachosOut.Rows[i];
                                if (r[COL_CONSECUTIVO_CLIENTE].ToString().Trim().Length == 0) continue;
                                conCliente = r[COL_CONSECUTIVO_CLIENTE].ToString();
                                var e = Entities.LGC_DESPACHO.
                                    Where(d => d.CONSECUTIVO_CLIENTE == conCliente)
                                    .FirstOrDefault();
                                if (e != null) { sql.Clear(); throw new GeneralControllerException(string.Format("El registro en la fila {0} ya existe.(Consec:{1})", i + 1, conCliente)); }
                                s = string.Format(SQL_IN_DESPACHO,
                                    ClienteID,
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CONSECUTIVO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CONSECUTVO_AVMK),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CONSECUTIVO_CLIENTE),
                                    EntUtils.GetDTFromDtRow(r, GV_COL_FECHA_ENVIO_ARCHIVO, false).Value.ToString("dd/MM/yyyy"),
                                    "",
                                    "",
                                    EntUtils.GetDTFromDtRow(r, GV_COL_FECHA_DE_REDENCION, false).Value.ToString("dd/MM/yyyy"),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CEDULA),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CLIENTE),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_ENTREGAR_A),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_DIRECCION),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CIUDAD),
                                    EntUtils.GetIntFromDtRow(r, GV_COL_DEPARTAMENTO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_TELEFONO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CELULAR),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CORREO_ELECTRONICO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_CODIGO_PREMIO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_PREMIO),
                                    EntUtils.GetStrFromDtRow(r, GV_COL_ESPECIFICACIONES),
                                    EntUtils.GetIntFromDtRow(r, GV_COL_PROVEEDOR),
                                    EntUtils.GetIntFromDtRow(r, GV_COL_CANTIDAD),
                                    EntUtils.GetIntFromDtRow(r, GV_COL_VALOR),
                                    ClienteID);
                                sql.Append(s);
                            }
                            DataBaseUtils dbUtils = new DataBaseUtils();
                            return dbUtils.RunScriptFromStngBldr(sql, Entities);
                        }
                        catch (Exception ex)
                        {

                            string rData = "";
                            if (r != null)
                                rData = string.Join("|", r.ItemArray);
                            throw new Exception(string.Format("Error en fila {0}. [{1}] ", i + 1, rData) + ex.Message);
                        }

                    #endregion
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
            ImportDespachos,
            GetWorksheets,
            LoadRemitente,
            InsertDespachos,
            LoadCitiesFullName,
            LoadProveedores,
            IsInDespacho,
            GetCatalog = 44089
        }
        #endregion

    }
}
