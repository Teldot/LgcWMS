using AS.FW.Controller;
using AS.FW.Model;
using AS.FW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.Controllers.Access
{
    public class AcccessController : GeneralController
    {
        #region Attributes
        public static Dictionary<string, DateTime> LastIntents;
        #endregion
        #region Properties

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
                    case ActionType.LogIn:
                        #region LogIn
                        string us = RequestObj.TransParms.Where(p => p.Key == "user").FirstOrDefault().Value;
                        string pass = RequestObj.TransParms.Where(p => p.Key == "password").FirstOrDefault().Value;
                        //int compId = int.Parse(Codec.DecryptStringAES(RequestObj.TransParms.Where(p => p.Key == "company").FirstOrDefault().Value));
                        us = Codec.DecryptStringAES(us);

                        ValIntents(us);

                        ASFW_USER usr = FW_Entities.ASFW_USER.Where(u => u.USER == us && u.ACTIVE.Value).FirstOrDefault();
                        if (usr == null)
                            throw new AuthenticationException("Usuario/Contraseña incorrectos");
                        if (usr.PASS != pass)
                        {
                            int intent = 0;
                            if (usr.INTENTS.HasValue)
                            {
                                if (usr.INTENTS.Value >= 3)
                                {
                                    if ((DateTime.Now - usr.LAST_INTENT.Value).TotalMinutes < 60)
                                    {
                                        if (LastIntents.Count(l => l.Key == us) == 0)
                                            LastIntents.Add(us, DateTime.Now);
                                        usr.INTENTS = intent++;
                                        usr.LAST_INTENT = DateTime.Now;
                                        FW_Entities.SaveChanges();
                                        throw new AuthenticationException("Ha Excedido el numero máximo de intentos. Comuniquese con el Administrador del sistema.");
                                    }
                                }
                                intent = usr.INTENTS.Value;
                            }
                            usr.INTENTS = intent++;
                            usr.LAST_INTENT = DateTime.Now;
                            FW_Entities.SaveChanges();
                            throw new AuthenticationException("Usuario/Contraseña incorrectos");
                        }

                        if (LastIntents.Count(l => l.Key == (us)) > 0)
                            LastIntents.Remove(us);

                        Guid usrTokenId = Guid.NewGuid();

                        FW_Entities.ASFW_ACTIVESESSION.RemoveRange(FW_Entities.ASFW_ACTIVESESSION.Where(p => p.USERID == usr.USERID));
                        FW_Entities.ASFW_ACTIVESESSION.Add(new ASFW_ACTIVESESSION()
                        {
                            ACTIVESESSIONID = usrTokenId,
                            USERID = usr.USERID,
                            LASTACTIVITY = DateTime.Now,
                            COMPANYID = usr.COMPANYID
                        });
                        FW_Entities.SaveChanges();

                        var compny = FW_Entities.ASFW_COMPANY.Select(c => new { c.NAME, c.COMPANYID }).Where(c => c.COMPANYID == usr.COMPANYID).FirstOrDefault();

                        ResponseObj.UsrObj.UsrId = usr.USERID;
                        ResponseObj.UsrObj.UsrName = usr.FIRST_NAME +
                            //(string.IsNullOrEmpty(usr.SECOND_NAME) ? "" : " " + usr.SECOND_NAME) +
                            (string.IsNullOrEmpty(usr.FIRST_LASTNAME) ? "" : " " + usr.FIRST_LASTNAME);
                        //(string.IsNullOrEmpty(usr.SECOND_LASTNAME) ? "" : " " + usr.SECOND_LASTNAME)                            ;
                        ResponseObj.UsrObj.UsrPfl = usr.PROFILEID.Value;
                        ResponseObj.UsrObj.UsrToken = usrTokenId;
                        ResponseObj.UsrObj.UsrCpny = usr.COMPANYID;
                        ResponseObj.UsrObj.UsrCpnyN = compny.NAME;
                        ResponseObj.UsrObj.UsrConfParms = usr.CONFIG_PARMS;

                        ResponseObj.TransObjId = 10002;
                        ResponseObj.TransWindow = "content/home.html";
                        ResponseObj.MessCode = TransObj.MessCodes.Ok;

                        #endregion
                        break;
                    case ActionType.LogOut:
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
        public static void ValIntents(string us)
        {
            if (LastIntents == null)
                LastIntents = new Dictionary<string, DateTime>();

            if (LastIntents.Count(l => l.Key == us) > 0 &&
                (DateTime.Now - LastIntents.Where(l => l.Key == us).FirstOrDefault().Value).TotalMinutes < 60)
                throw new AuthenticationException("Ha Excedido el numero máximo de intentos. Comuniquese con el Administrador del sistema.");
        }
        #endregion
        #region Enums
        public enum ActionType
        {
            LogIn,
            LogOut
        }
        #endregion
        }
}
