using AS.FW.Model;
using LgcWMS.View.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LgcWMS
{
    static class Program
    {
        public static UsrObj usrObj = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if (usrObj != null)
                Application.Run(new View.Access.MainMenu());
        }
    }
}
