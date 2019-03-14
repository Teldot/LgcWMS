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
    public partial class IngMovInv : Form
    {
        const string SQL_ = "SELECT INVENTARIO_ID,PRODUCTO_ID,PRODUCTO,CANTIDAD,BODEGA_ID,BODEGA, RACK_ID, RACK, POSICION_ID, POSICION FROM V_LGD_INVENTARIO";
        const string SQL_1 = "select CATVALID, VAL from ASFW_CATVAL where CATTYPEID = 48";
        const string SQL_2 = "select CODIGO, DETALLE from LGC_WMS_PRODUCTO";
        const string SQL_3 = "";
        const string SQL_4 = "";

        public IngMovInv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
