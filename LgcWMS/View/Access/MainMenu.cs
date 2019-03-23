using LgcWMS.View.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgcWMS.View.Access
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Assembly assemby = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assemby.Location);
            ssStatus.Items["tsslVer"].Text = "ver." + info.ProductVersion;
            ssStatus.Items["tsslUser"].Text = "Usuario: " + Program.usrObj.UsrName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Confirma...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnImpEnvios_Click(object sender, EventArgs e)
        {
            ImportOrdEnvios ioe = new ImportOrdEnvios();
            ioe.ShowDialog();
        }

        private void btnDespachos_Click(object sender, EventArgs e)
        {
            CreacionGuia cG = new CreacionGuia();
            cG.ShowDialog();
        }
    }
}
