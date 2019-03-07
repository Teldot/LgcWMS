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

namespace LgcWMS.Business.Controllers
{
    public class DespachosController : GeneralController
    {
        #region Attributes

        #endregion
        #region Properties

        #endregion
        #region Constructor
        public DespachosController()
        {
            LgcWebEntities Entities;
        }
        #endregion
        #region Override Methods
        public override object GetData(int actionType)
        {
            //return base.GetData(actionType);
            ResponseObj = new TransObj();

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
                        //Barcode b = new Barcode();
                        Barcode b = new Barcode();
                        Image img = b.Encode(BarcodeLib.TYPE.UPCA, "038000356216", Color.Black, Color.White, 300, 150);
                        Stream stream = null;
                        img.Save(stream, ImageFormat.Jpeg);

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

        #endregion
        #region Enums
        public enum ActionType
        {
            ImportDespachos
        }
        #endregion

    }
}
