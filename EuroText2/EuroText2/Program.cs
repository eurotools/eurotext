using System;
using System.Windows.Forms;

namespace EuroText2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Show Splash Screen
            FrmMain mainForm = new FrmMain();
            using (FrmSplash programSplash = new FrmSplash(mainForm))
            {
                programSplash.ShowDialog();
            }

            //Start application
            Application.Run(mainForm);
        }
    }
}
