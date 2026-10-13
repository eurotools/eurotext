using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuroText2
{
    public partial class Frm_AlphaCycle : Form
    {
        public string EffectText { get; private set; }

        public Frm_AlphaCycle()
        {
            EffectText = string.Empty;
            InitializeComponent();
            UpdateControls();
        }

        private void Button_AddAlpha_Click(object sender, EventArgs e)
        {
            ListBox_Alphas.Items.Add(Convert.ToInt32(Numeric_Alpha.Value));
            ListBox_Alphas.SelectedIndex = ListBox_Alphas.Items.Count - 1;
            UpdateControls();
        }

        private void Button_UpdateAlpha_Click(object sender, EventArgs e)
        {
            if (ListBox_Alphas.SelectedIndex >= 0)
            {
                int selectedIndex = ListBox_Alphas.SelectedIndex;
                ListBox_Alphas.Items[selectedIndex] = Convert.ToInt32(Numeric_Alpha.Value);
                ListBox_Alphas.SelectedIndex = selectedIndex;
            }
        }

        private void Button_RemoveAlpha_Click(object sender, EventArgs e)
        {
            if (ListBox_Alphas.SelectedIndex >= 0)
            {
                ListBox_Alphas.Items.RemoveAt(ListBox_Alphas.SelectedIndex);
                UpdateControls();
            }
        }

        private void ListBox_Alphas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Alphas.SelectedItem != null)
            {
                Numeric_Alpha.Value = Convert.ToDecimal(ListBox_Alphas.SelectedItem);
            }
            UpdateControls();
        }

        private void UpdateControls()
        {
            bool hasSelection = ListBox_Alphas.SelectedIndex >= 0;
            Button_UpdateAlpha.Enabled = hasSelection;
            Button_RemoveAlpha.Enabled = hasSelection;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (ListBox_Alphas.Items.Count < 2)
            {
                MessageBox.Show("Add at least two alpha values.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> values = new List<string> { Numeric_Speed.Value.ToString("0") };
            foreach (object alpha in ListBox_Alphas.Items)
            {
                values.Add(Convert.ToString(alpha));
            }

            EffectText = "<AC " + string.Join(",", values.ToArray()) + ">";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
