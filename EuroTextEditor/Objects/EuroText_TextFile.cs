﻿using System.Collections.Generic;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class EuroText_TextFile
    {
        //Info
        public string FirstCreated = string.Empty;
        public string CreatedBy = string.Empty;
        public string LastModified = string.Empty;
        public string LastModifiedBy = string.Empty;

        //Properties
        public string Group = string.Empty;
        public string OutputSection = string.Empty;
        public int DeadText;
        public int MaxNumOfChars;

        //Messages
        public Dictionary<string, string> Messages = new Dictionary<string, string>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}