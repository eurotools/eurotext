using System.Collections.Generic;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_ProjectFile
    {
        //Info
        public string FirstCreated = string.Empty;
        public string CreatedBy = string.Empty;
        public string LastModified = string.Empty;
        public string LastModifiedBy = string.Empty;

        //Properties
        public string MessagesDirectory = string.Empty;
        public string SpreadSheetsDirectory = string.Empty;
        public string EuroLandHahCodesServPath = string.Empty;
        public int TextSectionsID = 0;
        public int UnusedTextBit = -1;

        //Settings
        public List<string> Languages = new List<string>();
        public List<string> Categories = new List<string>();
        public List<string> Genders = new List<string>();
        public List<string> Tones = new List<string>();
        public List<string> Contexts = new List<string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}