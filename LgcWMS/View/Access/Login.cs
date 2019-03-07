using AS.FW.Model;
using AS.FW.Services;
using LgcWMS.Business.Controllers.Access;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgcWMS.View.Access
{
    public partial class Login : Form
    {
        #region Attributes
        AccessController controller;
        TransObj responseObj;
        #endregion
        #region Properties

        #endregion
        #region Constructor
        public Login()
        {
            InitializeComponent();
            controller = new AccessController();
        }
        #endregion

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Text.Trim().Length == 0) { throw new Exception("Ingrese Usuario"); }
                if (PasswordTextBox.Text.Trim().Length == 0) { throw new Exception("Ingrese contraseña"); }

                Cursor.Current = Cursors.WaitCursor;
                string us = JsonConvert.SerializeObject(Codec.EncryptStringToBytes(UsernameTextBox.Text.Trim()));
                string ps = JsonConvert.SerializeObject(Codec.EncryptStringToBytes(PasswordTextBox.Text.Trim()));

                TransObj to = new TransObj();
                to.TransParms = new List<TransParm>();
                to.TransParms.Add(new TransParm("user", us));
                to.TransParms.Add(new TransParm("password", ps));

                controller.RequestObj = to;
                responseObj = (TransObj)controller.GetData((int)AccessController.ActionType.LogIn);
                if (responseObj != null && responseObj.UsrObj != null)
                    Program.usrObj = responseObj.UsrObj;
                Close();
                DialogResult = DialogResult.OK;
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
