﻿using AS.FW.Controller;
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
        const string SQL_IN_DESPACHO = @"INSERT INTO LGC_DESPACHO (REMITENTE,CONSECUTIVO,CONSECUTIVO_AVMK,CONSECUTIVO_CLIENTE,FECHA_ENVIO_ARCHIVO,MES,AÑO,FECHA_REDENCION,CEDULA,DESTINATARIO,ENTREGAR_A,DIRECCION,CIUDAD,DEPARTAMENTO,TELEFONO,CELULAR,CORREO_ELECTRONICO,CODIGO_PREMIO,PREMIO,ESPECIFICACIONES,PROVEEDOR_ID,CANTIDAD)
VALUES({ 0},'{1}','{2}','{3}',convert(date,'{4}',103),'{5}',{6},convert(date,'{7}',103),{8},'{9}','{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}','{19}',{20},{21});";
        const string SQL_CIUDADES = "SELECT V.ID catId, C.NOMBRES catVal FROM V_ASFW_CITY_CODE V INNER JOIN ASFW_CITY_CODE C ON V.ID = C.ID";
        const string SQL_PROVEEDORES = "SELECT PROVEEDOR_ID catId, NOMBRE catVal FROM LGC_CLIENTE_PROVEEDORES P INNER JOIN ASFW_COMPANY C ON P.CLIENTEID = C.CLIENT_ID WHERE C.COMPANYID = {0};";
        #region Column Indexes
        //public const int COL_REMITENTE = 2;
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
        public const int COL_GUIA_ID = 22;
        #endregion
        #endregion
        #region Properties
        LgcWebEntities Entities;
        public DataTable DtDespachosIn { get; set; }
        public List<GeneralCat> Deptos { get; set; }
        public List<GeneralCat> CitiesFullNames { get; set; }
        public List<GeneralCat> CitiesDeptos { get; set; }
        public List<GeneralCat> Proveedores { get; set; }
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
            int cat;
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
                    case ActionType.ImportDespachos:
                        #region ImportDespachos
                        string fileName = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "fName").FirstOrDefault().Value);
                        string workSheet = JsonConvert.DeserializeObject<string>(RequestObj.TransParms.Where(p => p.Key == "workSheet").FirstOrDefault().Value);
                        ExcelLoader exLoader = new ExcelLoader();
                        DtDespachosIn = exLoader.LoadFile(fileName, workSheet);
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
                        int cId = JsonConvert.DeserializeObject<int>(RequestObj.TransParms.Where(p => p.Key == "cId").FirstOrDefault().Value);
                        Proveedores = Entities.Database.SqlQuery<GeneralCat>(string.Format(SQL_PROVEEDORES, cId)).ToList();
                        #endregion
                        break;
                    case ActionType.InsertDespachos:
                        #region InsertDespachos
                        int provId = JsonConvert.DeserializeObject<int>(RequestObj.TransParms.Where(p => p.Key == "provId").FirstOrDefault().Value);
                        DataRow r = null;
                        sql = new StringBuilder();
                        string s = "";
                        for (int i = 0; i < DtDespachosIn.Rows.Count; i++)
                        {
                            r = DtDespachosIn.Rows[i];
                            var e = Entities.LGC_DESPACHO.
                                Where(d => d.CONSECUTIVO_CLIENTE == r[COL_CONSECUTIVO_CLIENTE].ToString())
                                .FirstOrDefault();
                            if (e != null) { sql.Clear(); throw new GeneralControllerException(string.Format("El registro en la fila {0} ya existe.", i)); }
                            s = string.Format(SQL_IN_DESPACHO,
                                provId,
                                EntUtils.GetStrFromDtRow(r, COL_CONSECUTIVO),
                                EntUtils.GetStrFromDtRow(r, COL_CONSECUTIVO_AVMK),
                                EntUtils.GetStrFromDtRow(r, COL_CONSECUTIVO_CLIENTE),
                                EntUtils.GetDTFromDtRow(r, COL_FECHA_ENVIO_ARCHIVO),
                                EntUtils.GetStrFromDtRow(r, COL_MES),
                                EntUtils.GetIntFromDtRow(r, COL_AÑO),
                                EntUtils.GetDTFromDtRow(r, COL_FECHA_REDENCION),
                                EntUtils.GetIntFromDtRow(r, COL_CEDULA),
                                EntUtils.GetStrFromDtRow(r, COL_DESTINATARIO),
                                EntUtils.GetStrFromDtRow(r, COL_ENTREGAR_A),
                                EntUtils.GetStrFromDtRow(r, COL_DIRECCION),
                                EntUtils.GetStrFromDtRow(r, COL_CIUDAD),
                                EntUtils.GetIntFromDtRow(r, COL_DEPARTAMENTO),
                                EntUtils.GetStrFromDtRow(r, COL_TELEFONO),
                                EntUtils.GetStrFromDtRow(r, COL_CELULAR),
                                EntUtils.GetStrFromDtRow(r, COL_CORREO_ELECTRONICO),
                                EntUtils.GetStrFromDtRow(r, COL_CODIGO_PREMIO),
                                EntUtils.GetStrFromDtRow(r, COL_PREMIO),
                                EntUtils.GetStrFromDtRow(r, COL_ESPECIFICACIONES),
                                EntUtils.GetIntFromDtRow(r, COL_PROVEEDOR_ID),
                                EntUtils.GetIntFromDtRow(r, COL_CANTIDAD));
                            sql.Append(s);
                        }
                        DataBaseUtils dbUtils = new DataBaseUtils();
                        return dbUtils.RunScriptFromStngBldr(sql, Entities);

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
            InsertDespachos,
            LoadCitiesFullName,
            LoadProveedores,
            GetCatalog = 44089
        }
        #endregion

    }
}
