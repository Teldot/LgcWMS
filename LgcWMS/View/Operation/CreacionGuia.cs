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
        const string SQL_GET_CONSECT = "SELECT CONSECUTIVO_CLIENTE catId, CONSECUTIVO_CLIENTE catVal FROM V_LGC_DESPACHO WHERE DATEDIFF(DAY,FECHA_ENVIO_ARCHIVO,GETDATE())<5;";
        const string SQL_GET_PROVE = "SELECT PROVEEDOR_ID catId, NOMBRE catVal FROM V_LGC_CLIENTE_PROVEEDORES ORDER BY NOMBRE;";
        #endregion
        #region Properties

        #endregion
        #region Constructor
        public CreacionGuia()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion

        #region Enums

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbNombreProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
