using AS.FW.Controller;
using AS.FW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LgcWMS.Business.Controllers.Operation
{
    public class GuiasController : GeneralController
    {
        #region Attributes

        #endregion
        #region Properties

        #endregion
        #region Contructor

        #endregion
        #region Override Methods
        public override object GetData(int actionType)
        {
            //return base.GetData(actionType);
            ResponseObj = new TransObj();
            try
            {

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
            GetDespachoByProveedor
        }
        #endregion
    }
}
