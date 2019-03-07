using AS.FW.Controller;
using AS.FW.Model;
using LgcWMS.Data.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.Controllers.Catalogs
{
    public class CatalogsController : GeneralController
    {
        #region Attributes
        LgcWebEntities Entities;
        #endregion
        #region Properties

        #endregion
        #region Constructor
        public CatalogsController()
        {
            Entities = new LgcWebEntities();
        }
        #endregion
        #region Override Methods
        public override object GetData(int actionType)
        {
            ResponseObj = new TransObj();
            bool itemZero = false, _new;
            int cat, id = 0;
            //CatTypes ctype;
            try
            {
                ActionType dType = (ActionType)actionType;
                switch (dType)
                {
                    case ActionType.GetAllCatTypes:
                        #region GetAllCatTypes
                        itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        var catTps = (from c in Entities.V_ASFW_CATTYPE
                                      where c.VISIBLE
                                      select new { c.CATTYPEID, c.NAME }).OrderBy(c => c.NAME).ToList();
                        if (itemZero)
                            catTps.Insert(0, new { CATTYPEID = -1, NAME = "Seleccione..." });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(catTps)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;
                        #endregion
                        break;
                    case ActionType.GetAllCatalogs:
                        break;
                    case ActionType.GetCatalog:
                        #region GetCatalog
                        cat = int.Parse(RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        //ctype = (CatTypes)Enum.Parse(typeof(CatTypes), reqCat);
                        if (cat == (int)CatTypes.CIUDAD)
                            return GetData((int)ActionType.GetCiudad);
                        else if (cat == (int)CatTypes.DEPARTAMENTO)
                            return GetData((int)ActionType.GetDepto);

                        if (RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault() != null)
                            itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        int catParent = -1;
                        if (RequestObj.TransParms.Where(p => p.Key == "catPar0").FirstOrDefault() != null)
                            catParent = int.Parse(RequestObj.TransParms.Where(p => p.Key == "catPar0").FirstOrDefault().Value);

                        var catgs = (from c in Entities.V_ASFW_CATVAL
                                     where c.CATTYPEID == cat && c.SHOWABLE.Value &&
                                     (catParent == -1 || c.CATPARENT0 == catParent)
                                     select new { catId = c.CATVALID, catVal = c.VAL }).OrderBy(c => c.catVal).ToList();

                        if (itemZero)
                            catgs.Insert(0, new { catId = -1, catVal = "Seleccione..." });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(catgs)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;

                        #endregion
                        break;
                    case ActionType.GetCiudad:
                        #region GetCiudad
                        if (RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault() != null)
                            itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        //int dep = int.Parse(RequestObj.TransParms.Where(p => p.Key == "catPar0").FirstOrDefault().Value);
                        var catCiud = (from c in Entities.V_ASFW_CITY_CODE_MUN
                                       //where c.DEPTO_ID == dep
                                       select new { catId = c.ID.Value, catVal = c.MUN_DEPTO }).OrderBy(c => c.catVal).ToList();

                        if (itemZero)
                            catCiud.Insert(0, new { catId = -1, catVal = "Seleccione..." });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(catCiud)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;
                        #endregion
                        break;
                    case ActionType.GetDepto:
                        #region GetDepto
                        if (RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault() != null)
                            itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        var catDeps = (from d in Entities.V_ASFW_CITY_CODE_DEP
                                       select new { catId = d.ID.ToString(), catVal = d.NOM_DEPTO }).OrderBy(d => d.catVal).ToList();

                        if (itemZero)
                            catDeps.Insert(0, new { catId = "-1", catVal = "Seleccione..." });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(catDeps)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;

                        #endregion
                        break;
                    case ActionType.GetCtlgFields:
                        #region GetCtlgFields
                        //ctype = (CatTypes)Enum.Parse(typeof(CatTypes), RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        if (RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault() != null)
                            itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        cat = int.Parse(RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        var catgFlds = (from c in Entities.V_ASFW_CATVAL
                                        where c.ACTIVE.Value && c.SHOWABLE.Value && c.CATTYPEID == cat
                                        select new { catId = c.CATVALID, catVal = c.VAL, c.CUSTOMFIELD0, c.CUSTOMFIELD1, c.CUSTOMFIELD2 }).OrderBy(c => c.catVal).ToList();
                        if (itemZero)
                            catgFlds.Insert(0, new { catId = -1, catVal = "Seleccione...", CUSTOMFIELD0 = new decimal?(), CUSTOMFIELD1 = new decimal?(), CUSTOMFIELD2 = "" });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(catgFlds)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;
                        #endregion
                        break;
                    case ActionType.GetCats2Edit:
                        #region GetCats2Edit
                        //ctype = (CatTypes)Enum.Parse(typeof(CatTypes), RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        if (RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault() != null)
                            itemZero = bool.Parse(RequestObj.TransParms.Where(p => p.Key == "itemZero").FirstOrDefault().Value);
                        cat = int.Parse(RequestObj.TransParms.Where(p => p.Key == "cat").FirstOrDefault().Value);
                        var cats2E = (from c in Entities.V_ASFW_CATVAL
                                      where c.SHOWABLE.Value && c.CATTYPEID == cat
                                      select new { catId = c.CATVALID, catVal = c.VAL, c.CUSTOMFIELD0, c.CUSTOMFIELD1, c.CUSTOMFIELD2, c.ACTIVE }).OrderBy(c => c.catVal).ToList();
                        if (itemZero)
                            cats2E.Insert(0, new { catId = -1, catVal = "Seleccione...", CUSTOMFIELD0 = new decimal?(), CUSTOMFIELD1 = new decimal?(), CUSTOMFIELD2 = "", ACTIVE = new bool?() });

                        ResponseObj.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(cats2E)));
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;
                        #endregion
                        break;
                    case ActionType.SaveCatalog:
                        #region SaveCatalog
                        JObject catInfo = JObject.Parse(RequestObj.TransParms.Where(c => c.Key == "catInfo").FirstOrDefault().Value);
                        if (!string.IsNullOrEmpty(catInfo["catId"].ToString()))
                            id = int.Parse(catInfo["catId"].ToString());

                        Data.Model.ASFW_CATVAL cat2Save = Entities.ASFW_CATVAL.Where(c => c.CATVALID == id).FirstOrDefault();
                        _new = cat2Save == null;

                        if (_new)
                            cat2Save = new Data.Model.ASFW_CATVAL();

                        cat2Save.ACTIVE = Boolean.Parse(catInfo["ACTIVE"].ToString());
                        if (!string.IsNullOrEmpty(catInfo["CUSTOMFIELD0"].ToString()) && catInfo["CUSTOMFIELD0"].ToString() != "0")
                            cat2Save.CUSTOMFIELD0 = decimal.Parse(catInfo["CUSTOMFIELD0"].ToString());
                        cat2Save.CATTYPEID = int.Parse(catInfo["catType"].ToString());
                        cat2Save.VAL = catInfo["catVal"].ToString();
                        cat2Save.SHOWABLE = true;

                        if (_new)
                            Entities.ASFW_CATVAL.Add(cat2Save);

                        Entities.SaveChanges();

                        return GetData((int)ActionType.GetCats2Edit);
                    #endregion
                    case ActionType.DeleteCatalog:
                        #region DeleteCatalog
                        id = int.Parse(RequestObj.TransParms.Where(p => p.Key == "catId").FirstOrDefault().Value);

                        Data.Model.ASFW_CATVAL cat2Del = Entities.ASFW_CATVAL.Where(c => c.CATVALID == id).FirstOrDefault();
                        if (cat2Del == null)
                            throw new Exception("Catálogo no encontrado");

                        cat2Del.SHOWABLE = false;

                        Entities.SaveChanges();

                        return GetData((int)ActionType.GetCats2Edit);
                    #endregion
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ResponseObj.MessCode = TransObj.MessCodes.Error;
                ResponseObj.Mess = ex.Message;
            }

            return ResponseObj;
        }
        #endregion
        #region Methods

        #endregion
        #region Enums
        public enum ActionType
        {
            SaveCatalog = 91717,
            GetCats2Edit = 81578,
            GetCtlgFields = 28869,
            GetAllCatTypes = 84801,
            GetAllCatalogs = 34088,
            GetCatalog = 44089,
            DeleteCatalog = 24896,
            GetCiudad = 15478,
            GetDepto = 13698
        }
        //public enum CatTypes
        //{
        //    TIPO_IDENTIFICACION = 2,
        //    ACTIVIDAD_ECONOMICA = 12,
        //    FORMA_PAGO = 13,
        //    MOVIMIENTO = 14,
        //    DIRECTORIO = 18,
        //    ESTADO_HISTORIAL = 19,
        //    TIPO_PERSONA = 20,
        //    TIPO_CUENTA_BANCARIA = 21,
        //    TIPO_CONTACTO = 22,
        //    HORARIO_RECOLECCION = 23,
        //    UNIDAD_DE_MEDIDA = 24,
        //    TIPOS_DE_EMPAQUE = 25,
        //    DISPERSION = 26,
        //    TIPOS_EMPAQUE_MENS = 28,
        //    TIPOS_VEHICULO = 29,
        //    REGIMEN = 30,
        //    BANCO = 32,
        //    TRANSPORTADORA = 33,
        //    CLASE_SOCIEDAD = 34
        //}

        //public enum CatParentesco
        //{
        //    HIJO = 6,
        //    HIJASTRO = 7,
        //    HERMANO = 8,
        //    PADRE = 9,
        //    MADRE = 10,
        //    CONYUGE = 16,
        //    TITULAR = 17
        //}

        //public enum CatCompanies
        //{
        //    Mendel = 1,
        //    Tesla = 2,
        //    SAP = 3
        //}
        #endregion
    }

    public class GeneralCat {
        public int catId { get; set; }
        public string catVal { get; set; }
    }

}
