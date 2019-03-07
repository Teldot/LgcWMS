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

            try
            {
                if (cbCliente.SelectedIndex == -1 || cbCliente.SelectedIndex == 0) { throw new Exception("No ha selccionado cliente"); }
                if (controller.CitiesFullNames == null || controller.CitiesFullNames.Count == 0)
                    controller.GetData((int)DespachosController.ActionType.LoadCitiesFullName);
                if (controller.Proveedores == null || controller.Proveedores.Count == 0)
                {
                    TransObj ob = new TransObj();
                    ob.TransParms.Add(new TransParm("cId", JsonConvert.SerializeObject(cbCliente.SelectedValue)));
                    controller.RequestObj = ob;
                    controller.GetData((int)DespachosController.ActionType.LoadProveedores);
                }

                DataRow r;
                for (int i = 0; i < controller.DtDespachosIn.Rows.Count; i++)
                {
                    r = controller.DtDespachosIn.Rows[i];

                    validateDepto(r, i);
                    validateCiudad(r, i);
                    validateProveedor(r, i);
                }
            }
            catch (Exception ex)
            {
                tbError.Text = ex.Message;
            }
        }

        public void validateCiudad(DataRow r, int i)
        {
            if (r[DespachosController.COL_CIUDAD] == null || r[DespachosController.COL_CIUDAD].ToString().Trim().Length == 0)
                throw new Exception(string.Format("No hay ciudad (Fila: {0})", i + 1));
            //string depto = r[DespachosController.COL_DEPARTAMENTO].ToString();

            var cs = controller.CitiesFullNames.Where(c => c.catVal.Contains(r[DespachosController.COL_CIUDAD].ToString())).ToList();
            if (cs == null || cs.Count == 0)
                throw new Exception(string.Format("No se encontro la ciudad (Fila: {0})", i + 1));
            //{
            //    if (r[DespachosController.COL_DEPARTAMENTO] == null || r[DespachosController.COL_DEPARTAMENTO].ToString().Trim().Length == 0)
            //        throw new Exception(string.Format("No se encontro la ciudad y no hay departamento (Fila: {0})", i + 1));
            //    cs = controller.CitiesDeptos.Where(
            //        c => c.catVal.Contains(r[DespachosController.COL_CIUDAD].ToString()) &&
            //        c.catVal.Contains(r[DespachosController.COL_DEPARTAMENTO].ToString())
            //        ).ToList();
            //    if (cs == null || cs.Count == 0)
            //        throw new Exception(string.Format("No se encontro la ciudad (Fila: {0})", i + 1));
            //}

            if (cs.Count > 1)
            {
                if (r[DespachosController.COL_DEPARTAMENTO] == null || r[DespachosController.COL_DEPARTAMENTO].ToString().Trim().Length == 0)
                    throw new Exception(string.Format("No se encontro la ciudad y no hay departamento (Fila: {0})", i + 1));
                cs = controller.CitiesDeptos.Where(
                    c => c.catVal.Contains(r[DespachosController.COL_CIUDAD].ToString()) &&
                    c.catVal.Contains(r[DespachosController.COL_DEPARTAMENTO].ToString())
                    ).ToList();
                if (cs == null || cs.Count == 0)
                    throw new Exception(string.Format("No se encontro la ciudad (Fila: {0})", i + 1));
                if (cs.Count > 1)
                    throw new Exception(string.Format("(Fila: {0})", i + 1) + "La ciudad se encontro mas de una vez. \nModifique por alguno de estos valores:\n" +
                   string.Join("\n", cs.Select(c => c.catVal).ToArray()));
            }


            dgEnvios[i, DespachosController.COL_CIUDAD].Value = cs[0].catId;
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

            dgEnvios[i, DespachosController.COL_DEPARTAMENTO].Value = cs[0].catId;
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

            dgEnvios[i, DespachosController.COL_PROVEEDOR_ID].Value = cs[0].catId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
