using System.Collections.Generic;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_TextSections
    {
        //Info
        public string FirstCreated = string.Empty;
        public string CreatedBy = string.Empty;
        public string LastModified = string.Empty;
        public string LastModifiedBy = string.Empty;

        //Text Sections
        public Dictionary<string, string> TextSections = new Dictionary<string, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
