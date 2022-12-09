using System;
using System.Windows.Forms;

namespace EuroTextEditor
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
            Frm_MainFrame mainForm = new Frm_MainFrame();
            using (Frm_Splash programSplash = new Frm_Splash(mainForm))
            {
                programSplash.ShowDialog();
            }

            //Start application
            Application.Run(mainForm);
        }
    }
}
