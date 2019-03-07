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

        const string SQL_GET_CLIENTES = "SELECT COMPANYID, NOMBRERAZONSOCIAL, CLIENTEID  FROM V_LGC_CLIENTE WHERE ACTIVO = 1 ORDER BY NOMBRERAZONSOCIAL;";
        const string SQL_IN_DESPACHO = @"INSERT INTO LGC_DESPACHO (REMITENTE,CONSECUTIVO,CONSECUTIVO_AVMK,CONSECUTIVO_CLIENTE,FECHA_ENVIO_ARCHIVO,MES,AÑO,FECHA_REDENCION,CEDULA,DESTINATARIO,ENTREGAR_A,DIRECCION,CIUDAD,DEPARTAMENTO,TELEFONO,CELULAR,CORREO_ELECTRONICO,CODIGO_PREMIO,PREMIO,ESPECIFICACIONES,PROVEEDOR_ID,CANTIDAD)
VALUES({ 0},'{1}','{2}','{3}',convert(date,'{4}',103),'{5}',{6},convert(date,'{7}',103),{8},'{9}','{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}','{19}',{20},{21});";
        const int COL_REMITENTE = 2;
        const int COL_CONSECUTIVO = 3;
        const int COL_CONSECUTIVO_AVMK = 1;
        const int COL_CONSECUTIVO_CLIENTE = 1;
        const int COL_FECHA_ENVIO_ARCHIVO = 1;
        const int COL_MES = 1;
        const int COL_AÑO = 1;
        const int COL_FECHA_REDENCION = 1;
        const int COL_CEDULA = 1;
        const int COL_DESTINATARIO = 1;
        const int COL_ENTREGAR_A = 1;
        const int COL_DIRECCION = 1;
        const int COL_CIUDAD = 1;
        const int COL_DEPARTAMENTO = 1;
        const int COL_TELEFONO = 1;
        const int COL_CELULAR = 1;
        const int COL_CORREO_ELECTRONICO = 1;
        const int COL_CODIGO_PREMIO = 1;
        const int COL_PREMIO = 1;
        const int COL_ESPECIFICACIONES = 1;
        const int COL_PROVEEDOR_ID = 1;
        const int COL_CANTIDAD = 1;
        const int COL_GUIA_ID = 1;
        #endregion
        #region Properties
        LgcWebEntities Entities;
        public DataTable DtDespachosIn { get; set; }
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
            try
            {
                switch ((ActionType)actionType)
                {
                    case ActionType.ImportDespachos:
                        #region ImportDespachos
                        string fileName = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "fName").FirstOrDefault().Value);
                        string workSheet = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "workSheet").FirstOrDefault().Value);
                        ExcelLoader exLoader = new ExcelLoader();
                        DataTable dt = exLoader.LoadFile(fileName, workSheet);
                        return dt;
                    #endregion
                    case ActionType.LoadRemitente:
                        #region LoadRemitente
                        var clts = Entities.Database.SqlQuery<GeneralCat>(SQL_GET_CLIENTES).ToList();
                        clts.Insert(0, new GeneralCat { catId = -1, catVal = "Seleccione..." });

                        ResponseObj.TransParms.Add(new TransParm("clts", JsonConvert.SerializeObject(clts)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;
                        #endregion
                        break;
                    case ActionType.InsertDespachos:
                        #region InsertDespachos
                        DataRow r = null;
                        sql = new StringBuilder();
                        string s = "";
                        for (int i = 0; i < DtDespachosIn.Rows.Count; i++)
                        {
                            r = DtDespachosIn.Rows[i];
                            var e = Entities.LGC_DESPACHO.
                                Where(d => d.CONSECUTIVO_CLIENTE == r[COL_CONSECUTIVO_CLIENTE].ToString())
                                .FirstOrDefault();
                            if (e != null) throw new GeneralControllerException(string.Format("El registro en la fila {0} ya existe.", i));
                            s = string.Format(SQL_IN_DESPACHO,
                                EntUtils.GetIntFromDtRow()

                        }
                        #endregion
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return ResponseObj;
        }
        #endregion
        #region Methods
        public byte[] GenBarcode(string data)
        {
            Barcode b = new Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, data, Color.Black, Color.White, 450, 50);
            MemoryStream stream = new System.IO.MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();

        }
        #endregion
        #region Enums
        public enum ActionType
        {
            ImportDespachos,
            LoadRemitente,
            InsertDespachos
        }
        #endregion

    }
}
