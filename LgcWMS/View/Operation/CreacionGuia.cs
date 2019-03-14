using AS.FW.Model;
using LgcWMS.Business.Controllers.Operation;
using LgcWMS.Business.Utils;
using LgcWMS.Data.Entities;
using LgcWMS.Data.Model;
using LgcWMS.Reports;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgcWMS.View.Operation
{
    public partial class CreacionGuia : Form
    {
        #region Attributes
        //JObject printObj;
        private IList<Stream> m_streams;
        private int m_currentPageIndex;
        private long _guiaNo;
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

        private void Print(PrintingDocument pDoc)
        {
            try
            {
                RViewer rview;
                switch (pDoc)
                {
                    case PrintingDocument.Label:
                        #region Label
                        int sel = 0;
                        List<string> ids = new List<string>();
                        foreach (DataGridViewRow r in dgvDespachos.Rows)
                        {
                            if (((DataGridViewCheckBoxCell)r.Cells["Imp_Etqueta"]).Value == null) continue;
                            bool val = bool.Parse(((DataGridViewCheckBoxCell)r.Cells["Imp_Etqueta"]).Value.ToString());
                            if (val) { 
                                ids.Add(((DataGridViewTextBoxCell)r.Cells["GUIA_ID"]).Value.ToString());}
                        }

                        //if (sel < 2) { MessageBox.Show("Debe seleccionar al menos 2 registros para imprimir etiquetas"); return; }
                        if (ids.Count == 0) { MessageBox.Show("Debe seleccionar al menos 1 registro para imprimir etiquetas"); return; }

                        rview = new RViewer();
                        rview.ReportType = RViewer.ActionType.Label;
                        rview.PrinterName = cbPrinterLabel.Text;
                        controller.RequestObj.TransParms.Clear();
                        controller.RequestObj.TransParms.Add(new TransParm("gNo", JsonConvert.SerializeObject(ids.ToArray())));
                        List<V_GUIA_ETIQUETA> dSource = (List<V_GUIA_ETIQUETA>)controller.GetData((int)GuiasController.ActionType.GetLabels);

                        List<GUIA_LABEL_DUO> ds = new List<GUIA_LABEL_DUO>();
                        for (int i = 0; i < dSource.Count; i++)
                        {
                            GUIA_LABEL_DUO d = new GUIA_LABEL_DUO();
                            if (i % 2 == 0)
                            {
                                d.GUIA_PREFIJO1 = dSource[i].GUIA_PREFIJO;
                                d.GUIA_ID1 = dSource[i].GUIA_ID;
                                d.NOMBRE1 = dSource[i].NOMBRE;
                                d.DIRECCION1 = dSource[i].DIRECCION;
                                d.CIUDAD1 = dSource[i].CUIDAD;
                                d.REFERENCIA1 = dSource[i].REFERENCIA;
                                d.CONSECUTIVO_CLIENTE1 = dSource[i].CONSECUTIVO_CLIENTE;
                                d.BARCODE1 = BarcodeUtils.GenBarcode(d.GUIA_PREFIJO1 + d.GUIA_ID1.ToString());
                            }
                            i++;
                            if (i < dSource.Count)
                            {
                                d.GUIA_PREFIJO2 = dSource[i].GUIA_PREFIJO;
                                d.GUIA_ID2 = dSource[i].GUIA_ID;
                                d.NOMBRE2 = dSource[i].NOMBRE;
                                d.DIRECCION2 = dSource[i].DIRECCION;
                                d.CIUDAD2 = dSource[i].CUIDAD;
                                d.REFERENCIA2 = dSource[i].REFERENCIA;
                                d.CONSECUTIVO_CLIENTE2 = dSource[i].CONSECUTIVO_CLIENTE;
                                d.BARCODE2 = BarcodeUtils.GenBarcode(d.GUIA_ID2 + d.GUIA_ID2.ToString());
                            }
                            ds.Add(d);
                        }

                        rview.D_Source = ds;
                        rview.ShowDialog();

                        #endregion
                        break;
                    case PrintingDocument.Guia:
                        #region Guia
                        //LocalReport report = new LocalReport();
                        //report.ReportEmbeddedResource = @"LgcWMS.Reports.OrdenServicio.rdlc";
                        //controller.RequestObj.TransParms.Clear();
                        //controller.RequestObj.TransParms.Add(new TransParm("gNo", _guiaNo.ToString()));
                        //report.DataSources.Add(
                        //   new ReportDataSource("dsGuia", controller.GetData((int)GuiasController.ActionType.GetGuia)));
                        //Export(report);
                        //Print();

                        //WITH VIEWER
                        rview = new RViewer();
                        rview.ReportType = RViewer.ActionType.Guia;
                        rview.PrinterName = cbPrinterGuia.Text;
                        controller.RequestObj.TransParms.Clear();
                        controller.RequestObj.TransParms.Add(new TransParm("gNo", _guiaNo.ToString()));
                        rview.D_Source = controller.GetData((int)GuiasController.ActionType.GetGuia);
                        rview.ShowDialog();
                        #endregion
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.2in</PageWidth>
                <PageHeight>5.8in</PageHeight>
                <MarginTop>0.05in</MarginTop>
                <MarginLeft>0.05in</MarginLeft>
                <MarginRight>0.05in</MarginRight>
                <MarginBottom>0.05in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            PrinterSettings pSett = new PrinterSettings();
            pSett.Copies = 1;
            pSett.FromPage = 1;
            pSett.ToPage = 1;
            pSett.PrinterName = cbPrinterGuia.Text;
            printDoc.PrinterSettings = pSett;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
                           Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            //PORTRATE
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);



            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        #endregion

        #region Events
        private void CreacionGuia_Load(object sender, EventArgs e)
        {
            try
            {
                cbConsecClient.DataSource = controller.GetData((int)GuiasController.ActionType.GetConsecClient);
                cbConsecClient.DisplayMember = "catVal";
                cbConsecClient.ValueMember = "catId";
                cbProveedor.DataSource = controller.GetData((int)GuiasController.ActionType.GetProveedor);
                cbProveedor.DisplayMember = "catVal";
                cbProveedor.ValueMember = "catId";
                cbPlanilla.DataSource = controller.GetData((int)GuiasController.ActionType.GetConsec);
                cbPlanilla.DisplayMember = "catVal";
                cbPlanilla.ValueMember = "catId";

                List<string> ps1 = new List<string>();
                //ps1.Add("Selccione...");
                List<string> ps2 = new List<string>();
                //ps2.Add("Selccione...");
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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rIndex;
            try
            {
                if (string.IsNullOrEmpty(tbGuia.Text.Trim())) { MessageBox.Show("Ingrese # de Guia"); return; }
                if (dtFechaEnvio.Value.Date < DateTime.Now.Date) { MessageBox.Show("La Fecha de envio no puede ser anterior a hoy."); return; }
                if (string.IsNullOrEmpty(tbPeso.Text.Trim())) { MessageBox.Show("Ingrese peso"); return; }
                if (string.IsNullOrEmpty(tbPesoRealVol.Text.Trim())) { MessageBox.Show("Ingrese peso volumetrico"); return; }
                if (dgvDespachos.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar un registro"); return; }

                rIndex = dgvDespachos.SelectedRows[0].Index;
                var item = dgvDespachos.SelectedRows[0].DataBoundItem;
                string itemS = JsonConvert.SerializeObject(item);
                string obs = JsonConvert.DeserializeObject<JObject>(itemS)["CONSECUTIVO_CLIENTE"].ToString() + " - " + tbObservaciones.Text.Trim();
                controller.RequestObj.TransParms.Clear();
                controller.RequestObj.TransParms.Add(new TransParm("NoGuia", tbGuia.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("fEnvio", dtFechaEnvio.Value.Date.ToString("dd/MM/yyyy")));
                controller.RequestObj.TransParms.Add(new TransParm("peso", tbPeso.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("pesoVol", tbPesoRealVol.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("pesoLiq", tbPesoLiq.Text.Trim()));
                controller.RequestObj.TransParms.Add(new TransParm("obs", obs));
                controller.RequestObj.TransParms.Add(new TransParm("data", itemS));
                controller.RequestObj.TransParms.Add(new TransParm("usId", Program.usrObj.UsrId.ToString()));

                TransObj response = (TransObj)controller.GetData((int)GuiasController.ActionType.SaveData);
                if (response.MessCode == TransObj.MessCodes.Ok)
                //printObj = JsonConvert.DeserializeObject<JObject>(response.TransParms.Where(r => r.Key == "sGuia").FirstOrDefault().Value);
                {
                    controller.RequestObj.TransParms.Clear();
                    controller.RequestObj.TransParms.Add(new TransParm("id", controller.LastSearchData.ToString()));
                    dgvDespachos.DataSource = controller.GetData((int)controller.LastSearch);
                    dgvDespachos.Rows[rIndex].Selected = true;
                }
                //else
                //{
                //    printObj = null;
                //    MessageBox.Show(response.Mess);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            controller.RequestObj.TransParms.Clear();
            Print(PrintingDocument.Label);
        }

        private void btnPrintGuia_Click(object sender, EventArgs e)
        {
            controller.RequestObj.TransParms.Clear();
            Print(PrintingDocument.Guia);
        }

        private void cbConsecutivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsecClient.SelectedIndex != 0)
            {
                controller.RequestObj.TransParms.Clear();
                controller.RequestObj.TransParms.Add(new TransParm("consec", cbConsecClient.Text));
                dgvDespachos.DataSource = controller.GetData((int)GuiasController.ActionType.GetDespachoByConsec);
            }
            cbConsecClient.SelectedIndex = 0;
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedor.SelectedIndex != 0)
            {
                controller.RequestObj.TransParms.Clear();
                controller.RequestObj.TransParms.Add(new TransParm("prvId", cbProveedor.SelectedValue.ToString()));
                dgvDespachos.DataSource = controller.GetData((int)GuiasController.ActionType.GetDespachoByProveedor);
            }
            cbProveedor.SelectedIndex = 0;
        }

        private void cbPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlanilla.SelectedIndex != 0)
            {
                controller.RequestObj.TransParms.Clear();
                controller.RequestObj.TransParms.Add(new TransParm("plan", cbPlanilla.Text));
                dgvDespachos.DataSource = controller.GetData((int)GuiasController.ActionType.GetDespachoByPlanilla);
            }
            cbPlanilla.SelectedIndex = 0;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            int p = 0, pv = 0;
            if (!string.IsNullOrEmpty(tbPeso.Text)) p = int.Parse(tbPeso.Text);
            if (!string.IsNullOrEmpty(tbPesoRealVol.Text)) pv = int.Parse(tbPesoRealVol.Text);

            tbPesoLiq.Text = p > pv ? p.ToString() : pv.ToString();
        }

        private void dgvDespachos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDespachos.SelectedRows == null || dgvDespachos.SelectedRows.Count == 0) return;
            var item = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(dgvDespachos.SelectedRows[0].DataBoundItem));
            bool hasGuia = !(((Newtonsoft.Json.Linq.JValue)(item["GUIA"])).Value == null);
            gbGuiaData.Enabled = !hasGuia;
            btnPrintLabel.Enabled = btnPrintGuia.Enabled = hasGuia;
            if (hasGuia)
            {
                _guiaNo = long.Parse(item["GUIA"].ToString());
                tbGuia.Text = _guiaNo.ToString();
            }
            else
            {
                _guiaNo = 0;
                tbGuia.Text = string.Empty;

            }
        }

        private void llAllWithGuia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDespachos.Rows)
            {
                var item = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(dgvDespachos.SelectedRows[0].DataBoundItem));
                bool hasGuia = (((Newtonsoft.Json.Linq.JValue)(item["GUIA"])).Value != null);
                ((DataGridViewCheckBoxCell)row.Cells["Imp_Etqueta"]).Value = hasGuia;
            }
        }

        private void llNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDespachos.Rows)
            {
                //var item = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(dgvDespachos.SelectedRows[0].DataBoundItem));
                //bool hasGuia = !(((Newtonsoft.Json.Linq.JValue)(item["GUIA"])).Value != null);
                ((DataGridViewCheckBoxCell)row.Cells["Imp_Etqueta"]).Value = false;
            }
        }

        #endregion

        #region Enums
        enum PrintingDocument
        {
            Label,
            Guia
        }






        #endregion

        private void dgvDespachos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
