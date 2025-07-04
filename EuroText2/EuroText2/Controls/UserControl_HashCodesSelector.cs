﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_HashCodesSelector : UserControl
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        private string _defaultSection = string.Empty;
        internal string DefaultSection
        {
            get { return _defaultSection; }
            set
            {
                _defaultSection = value;
                if (!string.IsNullOrEmpty(_defaultSection))
                {
                    Combobox_HashCodes_Section.SelectedItem = DefaultSection;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private bool _forceHashTableSection;
        internal bool ForceHashTableSection
        {
            get { return _forceHashTableSection; }
            set
            {
                _forceHashTableSection = value;
                if (_forceHashTableSection)
                {
                    Combobox_HashCodes_Section.Enabled = false;
                }
                else
                {
                    Combobox_HashCodes_Section.Enabled = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_HashCodesSelector()
        {
            InitializeComponent();
            Textbox_FilePath.Text = Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void LoadHashCodesSections(string hashCodesFilePath)
        {
            //Get all sections
            HashSet<string> AvailableSections = new HashSet<string>();
            using (StreamReader file = new StreamReader(hashCodesFilePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.StartsWith("/*") && ln.Contains("HT_"))
                    {
                        AvailableSections.Add(ln.Trim('/').Trim('*').Trim());
                    }
                }
                file.Close();
            }

            //Add sections to the combobox
            if (AvailableSections.Count > 0)
            {
                Combobox_HashCodes_Section.BeginUpdate();
                Combobox_HashCodes_Section.Items.AddRange(AvailableSections.ToArray());
                Combobox_HashCodes_Section.SelectedIndex = 0;
                Combobox_HashCodes_Section.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Combobox_HashCodes_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get all sections
            string hashTableSection = Combobox_HashCodes_Section.SelectedItem.ToString() + "_";
            HashSet<string> AvailableHashCodes = CommonFunctions.ReadHashTableSection(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h"), hashTableSection);

            //Add sections to the combobox
            if (AvailableHashCodes.Count > 0)
            {
                Combobox_HashCodes.BeginUpdate();
                Combobox_HashCodes.Items.Clear();
                Combobox_HashCodes.Items.AddRange(AvailableHashCodes.ToArray());
                Combobox_HashCodes.SelectedIndex = 0;
                Combobox_HashCodes.EndUpdate();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
