using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EuroText2
{
    public partial class Frm_ColourCycle : Form
    {
        private sealed class ColourEntry
        {
            public Color Colour;
            public int Alpha;

            public override string ToString()
            {
                return string.Format("R {0}, G {1}, B {2}, A {3}", ToGameColour(Colour.R), ToGameColour(Colour.G), ToGameColour(Colour.B), Alpha);
            }
        }

        public string EffectText { get; private set; }

        public Frm_ColourCycle()
        {
            EffectText = string.Empty;
            InitializeComponent();
            UpdateControls();
        }

        private static int ToGameColour(int value)
        {
            return (value * 128 + 127) / 255;
        }

        private void CheckBox_Speed_CheckedChanged(object sender, EventArgs e)
        {
            Numeric_Speed.Enabled = CheckBox_Speed.Checked;
        }

        private void Button_AddColour_Click(object sender, EventArgs e)
        {
            if (ColorDialog_Colour.ShowDialog() == DialogResult.OK)
            {
                ListBox_Colours.Items.Add(new ColourEntry
                {
                    Colour = ColorDialog_Colour.Color,
                    Alpha = Convert.ToInt32(Numeric_Alpha.Value)
                });
                ListBox_Colours.SelectedIndex = ListBox_Colours.Items.Count - 1;
                UpdateControls();
            }
        }

        private void Button_UpdateColour_Click(object sender, EventArgs e)
        {
            ColourEntry entry = ListBox_Colours.SelectedItem as ColourEntry;
            if (entry == null)
            {
                return;
            }

            ColorDialog_Colour.Color = entry.Colour;
            if (ColorDialog_Colour.ShowDialog() == DialogResult.OK)
            {
                entry.Colour = ColorDialog_Colour.Color;
                entry.Alpha = Convert.ToInt32(Numeric_Alpha.Value);
                int selectedIndex = ListBox_Colours.SelectedIndex;
                ListBox_Colours.Items[selectedIndex] = entry;
                ListBox_Colours.SelectedIndex = selectedIndex;
            }
        }

        private void Button_RemoveColour_Click(object sender, EventArgs e)
        {
            if (ListBox_Colours.SelectedIndex >= 0)
            {
                ListBox_Colours.Items.RemoveAt(ListBox_Colours.SelectedIndex);
                UpdateControls();
            }
        }

        private void ListBox_Colours_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColourEntry entry = ListBox_Colours.SelectedItem as ColourEntry;
            if (entry != null)
            {
                Numeric_Alpha.Value = entry.Alpha;
            }
            UpdateControls();
        }

        private void UpdateControls()
        {
            bool hasSelection = ListBox_Colours.SelectedIndex >= 0;
            Button_UpdateColour.Enabled = hasSelection;
            Button_RemoveColour.Enabled = hasSelection;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (ListBox_Colours.Items.Count < 2)
            {
                MessageBox.Show("Add at least two colours.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> values = new List<string>();
            if (CheckBox_Speed.Checked)
            {
                values.Add(Numeric_Speed.Value.ToString("0"));
            }

            foreach (ColourEntry entry in ListBox_Colours.Items)
            {
                values.Add(ToGameColour(entry.Colour.R).ToString());
                values.Add(ToGameColour(entry.Colour.G).ToString());
                values.Add(ToGameColour(entry.Colour.B).ToString());
                values.Add(entry.Alpha.ToString());
            }

            EffectText = "<CC " + string.Join(",", values.ToArray()) + ">";
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
