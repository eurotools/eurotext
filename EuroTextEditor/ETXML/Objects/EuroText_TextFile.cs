using System.Collections.Generic;
using System.Drawing;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_TextFile
    {
        //Only used in the editor
        public Color RowColor;
        public string Notes = string.Empty;
        public string HashCode = string.Empty;
        public int textFlags = 0;

        //Info
        public string FirstCreated = string.Empty;
        public string CreatedBy = string.Empty;
        public string LastModified = string.Empty;
        public string LastModifiedBy = string.Empty;

        //Properties
        public string Group = string.Empty;
        public string[] OutputSection = new string[] { };
        public int DeadText;
        public int MaxNumOfChars;

        //Messages
        public Dictionary<string, string> Messages = new Dictionary<string, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
