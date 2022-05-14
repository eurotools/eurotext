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
        public Dictionary<int, string> TextSections = new Dictionary<int, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
