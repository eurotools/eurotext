using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class GlobalVariables
    {
        public static string HashtablesAdminPath = string.Empty;
        public static string WorkingDirectory = string.Empty;
        public static string EuroTextUser = string.Empty;
        public static string EuroTextIni = Path.Combine(Application.StartupPath, "EuroText.ini");
        public static EuroText_ProjectFile CurrentProject = new EuroText_ProjectFile();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
