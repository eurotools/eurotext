using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmHashTableSelector : Form
    {
        private readonly string TextSectionHashCode = string.Empty;
        private readonly string LevelHashCode = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmHashTableSelector(string _TextSectionHashCode = "", string _LevelHashCode = "")
        {
            InitializeComponent();
            TextSectionHashCode = _TextSectionHashCode;
            LevelHashCode = _LevelHashCode;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmTextSection_Load(object sender, EventArgs e)
        {
            //Set text sections
            string subFileHashTable = Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "HashCode_SubFile.h");
            if (File.Exists(subFileHashTable))
            {
                HashSet<string> htTextSection = CommonFunctions.ReadHashTableSection(subFileHashTable, "HT_TextSection");
                cbxSectionSelector.Items.AddRange(htTextSection.ToArray());
                if (!string.IsNullOrEmpty(TextSectionHashCode))
                {
                    cbxSectionSelector.SelectedItem = TextSectionHashCode;
                }
                else if (cbxSectionSelector.Items.Count > 0)
                {
                    cbxSectionSelector.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("HashCode_SubFile.h file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Set levels hashcodes
            string hashTableFilePath = Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h");
            if (File.Exists(hashTableFilePath))
            {
                HashSet<string> htFileSection = CommonFunctions.ReadHashTableSection(hashTableFilePath, "HT_File");
                cbxHashcodeSelector.Items.AddRange(htFileSection.ToArray());
                if (!string.IsNullOrEmpty(LevelHashCode))
                {
                    cbxHashcodeSelector.SelectedItem = LevelHashCode;
                }
                else if (cbxHashcodeSelector.Items.Count > 0)
                {
                    cbxHashcodeSelector.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Hashcodes.h file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
