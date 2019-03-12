using AS.FW.Model;
using LgcWMS.Business.Controllers.Catalogs;
using LgcWMS.Business.Controllers.Operation;
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

namespace LgcWMS.View.Operation
{
    public partial class ImportOrdEnvios : Form
    {
        #region Attributes
        DespachosController controller;
        #endregion
        #region Properties

        #endregion
        #region Contructor
        public ImportOrdEnvios()
        {
            InitializeComponent();
            controller = new DespachosController();
        }
        #endregion

        private void ImportOrdEnvios_Load(object sender, EventArgs e)
        {
            try
            {
                cbCliente.ValueMember = "catId";
                cbCliente.DisplayMember = "catVal";
                cbCliente.DataSource = (List<GeneralCat>)controller.GetData((int)DespachosController.ActionType.LoadRemitente);

                TransObj ob = new TransObj();
                ob.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(35)));
                ob.TransParms.Add(new TransParm("itemZero", JsonConvert.SerializeObject(true)));
                controller.RequestObj = ob;
                TransObj res = (TransObj)controller.GetData((int)DespachosController.ActionType.GetCatalog);
                controller.CitiesDeptos = JsonConvert.DeserializeObject<List<GeneralCat>>(res.TransParms[0].Value);
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Ciudad"]).DataSource = controller.CitiesDeptos;
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Ciudad"]).DisplayMember = "catVal";
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Ciudad"]).ValueMember = "catId";

                ob = new TransObj();
                ob.TransParms.Add(new TransParm("cat", JsonConvert.SerializeObject(36)));
                ob.TransParms.Add(new TransParm("itemZero", JsonConvert.SerializeObject(true)));
                controller.RequestObj = ob;
                res = (TransObj)controller.GetData((int)DespachosController.ActionType.GetCatalog);
                controller.Deptos = JsonConvert.DeserializeObject<List<GeneralCat>>(res.TransParms[0].Value);
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Departamento"]).DataSource = controller.Deptos;
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Departamento"]).DisplayMember = "catVal";
                ((DataGridViewComboBoxColumn)dgEnvios.Columns["Departamento"]).ValueMember = "catId";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                TransObj ob = new TransObj();
                ob.TransParms.Add(new TransParm("fName", JsonConvert.SerializeObject(tbRutaArchivo.Text)));
                ob.TransParms.Add(new TransParm("workSheet", JsonConvert.SerializeObject(tbWorkSheet.Text)));
                controller.RequestObj = ob;
                controller.GetData((int)DespachosController.ActionType.ImportDespachos);
                tbError.Text = "(" + controller.DtDespachosIn.Rows.Count + ") Registros cargados";
                dgEnvios.DataSource = controller.DtDespachosIn;
            }
            catch (Exception ex)
            {
                tbError.Text = ex.Message;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tbRutaArchivo.Text = openFileDialog1.FileName;
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                if (cbCliente.SelectedIndex == -1 || cbCliente.SelectedIndex == 0) { throw new Exception("No ha selccionado cliente"); }
                if (controller.CitiesFullNames == null || controller.CitiesFullNames.Count == 0)
                    controller.GetData((int)DespachosController.ActionType.LoadCitiesFullName);
                if (controller.Proveedores == null || controller.Proveedores.Count == 0)
                {
                    //TransObj ob = new TransObj();
                    //ob.TransParms.Add(new TransParm("cId", JsonConvert.SerializeObject(cbCliente.SelectedValue)));
                    //controller.RequestObj = ob;
                    controller.GetData((int)DespachosController.ActionType.LoadProveedores);
                    ((DataGridViewComboBoxColumn)dgEnvios.Columns["Nombre_Proveedor"]).DataSource = controller.Proveedores;
                    ((DataGridViewComboBoxColumn)dgEnvios.Columns["Nombre_Proveedor"]).DisplayMember = "catVal";
                    ((DataGridViewComboBoxColumn)dgEnvios.Columns["Nombre_Proveedor"]).ValueMember = "catId";
                }

                DataRow r;
                for (i = 0; i < controller.DtDespachosIn.Rows.Count; i++)
                {
                    r = controller.DtDespachosIn.Rows[i];

                    if (r[DespachosController.GV_COL_CONSECUTIVO].ToString().Length > 10)
                        throw new Exception(string.Format("Fila: {0})", i + 1) + DespachosController.GV_COL_CONSECUTIVO + ": El valor del campo excede los 10 caracteres de largo.");
                    validateDepto(r, i);
                    validateCiudad(r, i);
                    validateProveedor(r, i);
                }
            }
            catch (Exception ex)
            {
                tbError.Text = ex.Message;
                dgEnvios.Rows[i].Selected = true;
            }
        }

        public void validateCiudad(DataRow r, int i)
        {
            if (r[DespachosController.COL_CIUDAD] == null || r[DespachosController.COL_CIUDAD].ToString().Trim().Length == 0)
                throw new Exception(string.Format("No hay ciudad (Fila: {0})", i + 1));
            string depto = r[DespachosController.COL_DEPARTAMENTO].ToString();
            string city = r[DespachosController.COL_CIUDAD].ToString();

            int id = FindCiudadInCityList(city);
            if (id <= 0)
                id = FindCiudadInCityDeptoList(city, depto, i);


            ((DataGridViewComboBoxCell)dgEnvios.Rows[i].Cells[DespachosController.GV_COL_CIUDAD]).Value = id;
            //if (((DataGridViewComboBoxCell)dgEnvios.Rows[i].Cells[DespachosController.GV_COL_DEPARTAMENTO]).FormattedValue.ToString().Length == 0)
            if (string.IsNullOrEmpty(depto))
            {
                depto = ((DataGridViewComboBoxCell)dgEnvios.Rows[i].Cells[DespachosController.GV_COL_CIUDAD]).FormattedValue.ToString();
                depto = depto.Split('(')[1];
                depto = depto.Replace(")", "");
                r[DespachosController.COL_DEPARTAMENTO] = depto;
                validateDepto(r, i);
            }

        }

        public int FindCiudadInCityList(string city)
        {
            var cs = controller.CitiesFullNames.Where(c => c.catVal == city).ToList();
            if (cs == null || cs.Count == 0)
                cs = controller.CitiesFullNames.Where(c => c.catVal.Contains(city)).ToList();
            if (cs == null || cs.Count == 0)
                return 0;
            else if (cs.Count > 1)
                return -1;
            else
                return cs[0].catId;
        }

        public int FindCiudadInCityDeptoList(string city, string depto, int i)
        {
            if (string.IsNullOrEmpty(depto))
                throw new Exception(string.Format("No se encontro la ciudad y no hay departamento (Fila: {0})", i + 1));

            var cs = controller.CitiesDeptos.Where(c => c.catVal.Split('(')[0].Trim() == city && c.catVal.Split('(')[1].Contains(depto)).ToList();

            if (cs == null || cs.Count == 0 || cs.Count > 1)
            {
                cs = controller.CitiesDeptos.Where(c => c.catVal.Split('(')[0].Contains(city) && c.catVal.Split('(')[1].Contains(depto)).ToList();
                if (cs.Count > 1)
                    throw new Exception(
                    string.Format("(Fila: {0})", i + 1) + "La ciudad se encontro mas de una vez. " +
                    Environment.NewLine + "Modifique por alguno de estos valores:" + Environment.NewLine +
                       string.Join(Environment.NewLine, cs.Select(c => c.catVal).ToArray()));
                else if (cs == null || cs.Count == 0)
                    throw new Exception(string.Format("No se encontro la ciudad (Fila: {0})", i + 1));
                else
                    return cs[0].catId;
            }
            else
                return cs[0].catId;
        }

        public void validateDepto(DataRow r, int i)
        {
            if (r[DespachosController.COL_DEPARTAMENTO] == null || r[DespachosController.COL_DEPARTAMENTO].ToString().Trim().Length == 0)
                return;
            var cs = controller.Deptos.Where(c => c.catVal.Contains(r[DespachosController.COL_DEPARTAMENTO].ToString())).OrderBy(c => c.catVal).ToList();
            if (cs == null || cs.Count == 0)
                throw new Exception(string.Format("No se encontro el Departamento (Fila: {0})", i + 1));
            //if (cs.Count > 1)
            //    throw new Exception(string.Format("(Fila: {0})", i) + "La ciudad se encontro mas de una vez. \nModifique por alguno de estos valores:\n" +
            //       string.Join("\n", cs.Select(c => c.catVal).ToArray()));

            ((DataGridViewComboBoxCell)dgEnvios.Rows[i].Cells[DespachosController.GV_COL_DEPARTAMENTO]).Value = cs[0].catId;
        }

        public void validateProveedor(DataRow r, int i)
        {
            if (r[DespachosController.COL_PROVEEDOR_ID] == null || r[DespachosController.COL_PROVEEDOR_ID].ToString().Trim().Length == 0)
                throw new Exception(string.Format("No hay proveedor (Fila: {0})", i + 1));
            var cs = controller.Proveedores.Where(c => c.catVal.Contains(r[DespachosController.COL_PROVEEDOR_ID].ToString())).OrderBy(c => c.catVal).ToList();
            if (cs == null || cs.Count == 0)
                throw new Exception(string.Format("No se encontro el Proveedor (Fila: {0})", i + 1));
            if (cs.Count > 1)
                throw new Exception(string.Format("(Fila: {0})", i + 1) + "El proveedor se encontro mas de una vez. \nModifique por alguno de estos valores:\n" +
                   string.Join("\n", cs.Select(c => c.catVal).ToArray()));

            ((DataGridViewComboBoxCell)dgEnvios.Rows[i].Cells[DespachosController.GV_COL_PROVEEDOR]).Value = cs[0].catId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BuildDataTable();
                //TransObj ob = new TransObj();
                //ob.TransParms.Add(new TransParm("cId", JsonConvert.SerializeObject(cbCliente.SelectedValue)));
                //controller.RequestObj = ob;
                controller.GetData((int)DespachosController.ActionType.InsertDespachos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEnvios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            setRowNumber();
        }

        private void dgEnvios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            setRowNumber();
        }

        private void setRowNumber()
        {
            foreach (DataGridViewRow row in dgEnvios.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void BuildDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CONSECUTIVO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CONSECUTVO_AVMK));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CONSECUTIVO_CLIENTE));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_FECHA_ENVIO_ARCHIVO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_FECHA_DE_REDENCION));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CEDULA));

            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CLIENTE));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_ENTREGAR_A));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_DIRECCION));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CIUDAD));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_DEPARTAMENTO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_TELEFONO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CELULAR));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CORREO_ELECTRONICO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CODIGO_PREMIO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_PREMIO));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_ESPECIFICACIONES));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_NOMBRE_PROVEEDOR));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CODIGO_PROVEEDOR));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_CANTIDAD));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_VALOR));
            dt.Columns.Add(new DataColumn(DespachosController.GV_COL_TRANSPORTADOR));
            DataGridViewRow r;
            for (int i = 0; i < dgEnvios.Rows.Count; i++)
            {
                r = dgEnvios.Rows[i];
                DataRow dr = dt.NewRow();

                dr[DespachosController.GV_COL_CONSECUTIVO] = r.Cells[DespachosController.GV_COL_CONSECUTIVO].Value;
                dr[DespachosController.GV_COL_CONSECUTVO_AVMK] = r.Cells[DespachosController.GV_COL_CONSECUTVO_AVMK].Value;
                dr[DespachosController.GV_COL_CONSECUTIVO_CLIENTE] = r.Cells[DespachosController.GV_COL_CONSECUTIVO_CLIENTE].Value;
                dr[DespachosController.GV_COL_FECHA_ENVIO_ARCHIVO] = r.Cells[DespachosController.GV_COL_FECHA_ENVIO_ARCHIVO].Value;
                dr[DespachosController.GV_COL_FECHA_DE_REDENCION] = r.Cells[DespachosController.GV_COL_FECHA_DE_REDENCION].Value;
                dr[DespachosController.GV_COL_CEDULA] = r.Cells[DespachosController.GV_COL_CEDULA].Value;

                dr[DespachosController.GV_COL_CLIENTE] = r.Cells[DespachosController.GV_COL_CLIENTE].Value;
                dr[DespachosController.GV_COL_ENTREGAR_A] = r.Cells[DespachosController.GV_COL_ENTREGAR_A].Value;
                dr[DespachosController.GV_COL_DIRECCION] = r.Cells[DespachosController.GV_COL_DIRECCION].Value;
                dr[DespachosController.GV_COL_CIUDAD] = r.Cells[DespachosController.GV_COL_CIUDAD].Value;
                dr[DespachosController.GV_COL_DEPARTAMENTO] = r.Cells[DespachosController.GV_COL_DEPARTAMENTO].Value;
                dr[DespachosController.GV_COL_TELEFONO] = r.Cells[DespachosController.GV_COL_TELEFONO].Value;
                dr[DespachosController.GV_COL_CELULAR] = r.Cells[DespachosController.GV_COL_CELULAR].Value;
                dr[DespachosController.GV_COL_CORREO_ELECTRONICO] = r.Cells[DespachosController.GV_COL_CORREO_ELECTRONICO].Value;
                dr[DespachosController.GV_COL_CODIGO_PREMIO] = r.Cells[DespachosController.GV_COL_CODIGO_PREMIO].Value;
                dr[DespachosController.GV_COL_PREMIO] = r.Cells[DespachosController.GV_COL_PREMIO].Value;
                dr[DespachosController.GV_COL_ESPECIFICACIONES] = r.Cells[DespachosController.GV_COL_ESPECIFICACIONES].Value;
                dr[DespachosController.GV_COL_NOMBRE_PROVEEDOR] = r.Cells[DespachosController.GV_COL_NOMBRE_PROVEEDOR].Value;
                dr[DespachosController.GV_COL_CODIGO_PROVEEDOR] = r.Cells[DespachosController.GV_COL_CODIGO_PROVEEDOR].Value;
                dr[DespachosController.GV_COL_CANTIDAD] = r.Cells[DespachosController.GV_COL_CANTIDAD].Value;
                dr[DespachosController.GV_COL_VALOR] = r.Cells[DespachosController.GV_COL_VALOR].Value;
                dr[DespachosController.GV_COL_TRANSPORTADOR] = r.Cells[DespachosController.GV_COL_TRANSPORTADOR].Value;

                dt.Rows.Add(dr);
            }
            controller.DtDespachosOut = dt;
        }

        private void dgEnvios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void cbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex >= 0)
                controller.ClienteID = (int)cbCliente.SelectedValue;
        }
    }
}
