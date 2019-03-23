using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LgcWMS.Business.PrintDocs;

namespace LgcWMS.Reports
{
    public partial class RViewer : Form
    {
        #region Attributes

        #endregion
        #region Properties
        public ActionType ReportType { get; set; }
        public object D_Source { get; set; }
        public string PrinterName { get; set; }
        #endregion
        public RViewer()
        {
            InitializeComponent();
        }

        private void RViewer_Load(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Drawing.Printing.PaperSize size;
            PageSettings pg;
            PrinterSettings pSett;
            switch (ReportType)
            {
                case ActionType.Guia:
                    #region Guia
                    pg = new PageSettings();
                    pg.Margins.Top = 0;
                    pg.Margins.Bottom = 0;
                    pg.Margins.Left = 5;
                    pg.Margins.Right = 5;
                    size = new PaperSize();
                    size.RawKind = (int)PaperKind.Custom;
                    size.Height = 820;
                    size.Width = 580;
                    pg.PaperSize = size;
                    pg.Landscape = true;
                    this.V_GUIABindingSource.DataSource = D_Source;//typeof(LgcWMS.Data.Model.V_GUIA);
                    reportDataSource1.Name = "dsGuia";
                    reportDataSource1.Value = this.V_GUIABindingSource;
                    this.rv.LocalReport.DataSources.Add(reportDataSource1);
                    this.rv.LocalReport.ReportEmbeddedResource = "LgcWMS.Reports.OrdenServicio.rdlc";
                    rv.SetPageSettings(pg);
                    this.rv.RefreshReport();
                    rv.SetDisplayMode(DisplayMode.PrintLayout);

                    pSett = new PrinterSettings();
                    pSett.Copies = 1;
                    //pSett.FromPage = 1;
                    //pSett.ToPage = 1;
                    pSett.PrinterName = PrinterName;
                    rv.PrintDialog(pSett);

                    //if ( == DialogResult.OK)

                    break;
                #endregion
                case ActionType.Label:
                    #region Label
                    pg = new PageSettings();
                    pg.Margins.Top = 0;
                    pg.Margins.Bottom = 0;
                    pg.Margins.Left = 5;
                    pg.Margins.Right = 5;
                    size = new PaperSize();
                    size.RawKind = (int)PaperKind.Custom;
                    size.Height = 480;
                    size.Width = 400;
                    pg.PaperSize = size;
                    pg.Landscape = false;
                    this.GUIA_DUOBindingSource.DataSource = D_Source;//typeof(LgcWMS.Data.Model.V_GUIA);
                    reportDataSource1.Name = "DataSetGuiaDuo";
                    reportDataSource1.Value = this.GUIA_DUOBindingSource;
                    //ReportDataSource rpSource = new ReportDataSource("GuiaDuo", D_Source);
                    //this.V_GUIABindingSource.DataSource = rpSource;
                    this.rv.LocalReport.DataSources.Clear();
                    this.rv.LocalReport.DataSources.Add(reportDataSource1);
                    this.rv.LocalReport.ReportEmbeddedResource = "LgcWMS.Reports.LblDespacho.rdlc";
                    rv.SetPageSettings(pg);
                    /*rv.RefreshReport();*/
                    rv.SetDisplayMode(DisplayMode.PrintLayout);

                    //pSett = new PrinterSettings();
                    //pSett.Copies = 1;
                    //pSett.FromPage = 1;
                    //pSett.ToPage = 1;
                    //pSett.PrinterName = PrinterName;
                    //rv.PrintDialog(pSett);
                    rv.RefreshReport();
                    rv.PrintDialog();
                    break;
                    #endregion


                    break;
                default:
                    break;
            }

            this.rv.RefreshReport();
        }
        #region Enums
        public enum ActionType
        {
            Guia,
            Label
        }
        #endregion
    }
}
