using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ruta_de_evacuación_más_cercana
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
        
    }
}