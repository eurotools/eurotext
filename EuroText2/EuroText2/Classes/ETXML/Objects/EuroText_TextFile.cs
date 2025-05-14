using System.Collections.Generic;
using System.Drawing;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_TextFile
    {
        //Only used in the editor
        public Color RowColor;
        public string Notes = string.Empty;
        public string HashCode = string.Empty; //Used only when exporting 
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

        //Info
        public string Gender = string.Empty;
        public string Tone = string.Empty;
        public string Context = string.Empty;

        //Messages
        public Dictionary<string, string> Messages = new Dictionary<string, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
