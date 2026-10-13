using System.Collections.Generic;
using System.Drawing;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_ColorFile
    {
        //Info
        public string FirstCreated = string.Empty;
        public string CreatedBy = string.Empty;
        public string LastModified = string.Empty;
        public string LastModifiedBy = string.Empty;

        public List<EuroText_Color> Colors = new List<EuroText_Color>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_Color
    {
        public string Name;
        public Color WordColor;
        public Dictionary<string, string> Words = new Dictionary<string, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
