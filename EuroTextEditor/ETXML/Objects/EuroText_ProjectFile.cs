using System.Collections.Generic;

namespace EuroTextEditor
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

        //Languages
        public List<string> Languages = new List<string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
