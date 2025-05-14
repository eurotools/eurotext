using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SetTextGroup : Form
    {
        public string selectedTextGroup;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_SetTextGroup(string[] availableGroups)
        {
            InitializeComponent();

            //Add new items
            comboBox1.BeginUpdate();
            comboBox1.Items.AddRange(availableGroups);
            comboBox1.EndUpdate();

            //Select first item
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            selectedTextGroup = comboBox1.SelectedItem.ToString();
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
