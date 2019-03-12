using AS.FW.Model;
using LgcWMS.Business.Controllers.Operation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgcWMS.View.Operation
{
    public partial class CreacionGuia : Form
    {
        #region Attributes
        JObject printObj;


        #endregion
        #region Properties
        GuiasController controller;
        #endregion
        #region Constructor
        public CreacionGuia()
        {
            InitializeComponent();
            controller = new GuiasController();
        }
        #endregion

        #region Methods
        private void Search()
        {
            try
            {
                if (cbConsecutivo.SelectedIndex == 0 && cbProveedor.SelectedIndex == 0) { MessageBox.Show("Debe seleccionar Consecutivo o Proveedor"); return; }

                if (cbConsecutivo.SelectedIndex != 0)
                {
                    controller.RequestObj.TransParms.Add(new TransParm("consec", cbConsecutivo.Text));
                    dgvDespachos.DataSource = controller.GetData((int)GuiasController.ActionType.GetDespachoByConsec);
                }
                if (cbProveedor.SelectedIndex != 0)
                {
                    controller.RequestObj.TransParms.Add(new TransParm("prvId", cbProveedor.SelectedValue.ToString()));
                    dgvDespachos.DataSource = controller.GetData((int)GuiasController.ActionType.GetDespachoByProveedor);
                }
                cbConsecutivo.SelectedIndex = 0;
                cbProveedor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print(PrintDocument pDoc)
        {
            if (printObj == null) return;

            switch (pDoc)
            {
                case PrintDocument.Label:
                    break;
                case PrintDocument.Guia:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Events
        private void CreacionGuia_Load(object sender, EventArgs e)
        {
            try
            {
                cbConsecutivo.DataSource = controller.GetData((int)GuiasController.ActionType.GetConsec);
                cbConsecutivo.DisplayMember = "catVal";
                cbConsecutivo.ValueMember = "catId";
                cbProveedor.DataSource = controller.GetData((int)GuiasController.ActionType.GetProveedor);
                cbProveedor.DisplayMember = "catVal";
                cbProveedor.ValueMember = "catId";

                List<string> ps1 = new List<string>();
                ps1.Add("Selccione...");
                List<string> ps2 = new List<string>();
                ps2.Add("Selccione...");
                foreach (var p in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    ps1.Add(p.ToString());
                    ps2.Add(p.ToString());
                }
                cbPrinterGuia.DataSource = ps1;
                cbPrinterLabel.DataSource = ps2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }


        #endregion

        #region Enums
        enum PrintDocument
        {
            Label,
            Guia
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbGuia.Text.Trim())) { MessageBox.Show("Ingrese # de Guia"); return; }
                if (dtFechaEnvio.Value.Date < DateTime.Now.Date) { MessageBox.Show("La Fecha de envio no puede ser anterior a hoy."); return; }
                if (string.IsNullOrEmpty(tbPeso.Text.Trim())) { MessageBox.Show("Ingrese peso"); return; }
                if (string.IsNullOrEmpty(tbPesoRealVol.Text.Trim())) { MessageBox.Show("Ingrese peso volumetrico"); return; }
                if (dgvDespachos.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar un registro"); return; }

                var item = dgvDespachos.SelectedRows[0].DataBoundItem;
                controller.RequestObj.TransParms.Add(new TransParm("NoGuia", tbGuia.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("fEnvio", dtFechaEnvio.Value.Date.ToString("dd/MM/yyyy")));
                controller.RequestObj.TransParms.Add(new TransParm("peso", tbPeso.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("pesoVol", tbPesoRealVol.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("pesoLiq", tbPesoLiq.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("obs", tbObservaciones.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("data", JsonConvert.SerializeObject(item)));
                controller.RequestObj.TransParms.Add(new TransParm("usId", Program.usrObj.UsrId.ToString()));

                TransObj response = (TransObj)controller.GetData((int)GuiasController.ActionType.SaveData);
                if (response.MessCode == TransObj.MessCodes.Ok)
                    printObj = JsonConvert.DeserializeObject<JObject>(response.TransParms.Where(r => r.Key == "sGuia").FirstOrDefault().Value);
                else
                {
                    printObj = null;
                    MessageBox.Show(response.Mess);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (!(sender is TextBox)) return;
            TextBox s = (TextBox)sender;
            int p = 0, pv = 0;
            if (s.Name == "tbPeso" && !string.IsNullOrEmpty(s.Text))
                p = int.Parse(s.Text);
            if (s.Name == "tbPesoRealVol" && !string.IsNullOrEmpty(s.Text))
                pv = int.Parse(s.Text);

            tbPesoLiq.Text = p > pv ? p.ToString() : pv.ToString();
        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            Print(PrintDocument.Label);
        }

        private void btnPrintGuia_Click(object sender, EventArgs e)
        {
            Print(PrintDocument.Guia);
        }
    }
}
