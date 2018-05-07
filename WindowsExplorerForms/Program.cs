using System;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WindowsExplorerForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new xDSL_Tools());
        }
    }
}
