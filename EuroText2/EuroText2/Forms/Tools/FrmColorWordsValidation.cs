using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmColorWordsValidation : Form
    {
        private EuroText_ColorFile colorFile;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmColorWordsValidation()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmColorWordsValidation_Load(object sender, System.EventArgs e)
        {
            string colorWordsFile = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "WordsColor.etf");
            if (File.Exists(colorWordsFile))
            {
                ETXML_Reader filesReader = new ETXML_Reader();
                colorFile = filesReader.ReadWordsColorDocument(colorWordsFile);
            }
            else
            {
                colorFile = new EuroText_ColorFile();
            }

            //Print colors
            foreach (EuroText_Color colour in colorFile.Colors)
            {
                lbxColours.Items.Add(colour.Name);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Color listbox
        //-------------------------------------------------------------------------------------------------------------------------------
        private void lbxColours_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lbxLanguages.BeginUpdate();
            lbxLanguages.Items.Clear();
            lbxLanguages.EndUpdate();
            pnlColour.BackColor = SystemColors.Control;

            int index = lbxColours.SelectedIndex;
            if (index < 0 || index >= colorFile.Colors.Count)
            {
                return;
            }

            EuroText_Color colorData = colorFile.Colors[index];

            // Pintar el color
            pnlColour.BackColor = colorData.WordColor;

            // Cargar idiomas
            lbxLanguages.BeginUpdate();
            foreach (string lang in colorData.Words.Keys)
            {
                lbxLanguages.Items.Add(lang);
            }
            lbxLanguages.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Color panel
        //-------------------------------------------------------------------------------------------------------------------------------
        private void pnlColour_Click(object sender, System.EventArgs e)
        {
            //Get object
            int index = lbxColours.SelectedIndex;
            if (index < 0 || index >= colorFile.Colors.Count)
            {
                return;
            }
            EuroText_Color colorData = colorFile.Colors[index];

            //Modify or set colour
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = colorData.WordColor;
                dlg.FullOpen = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Modificar EL OBJETO seleccionado
                    colorData.WordColor = dlg.Color;

                    // Reflejar el cambio en la UI
                    pnlColour.BackColor = dlg.Color;

                    // Forzar repintado del ListBox (si dibujas colores ahí)
                    lbxColours.Invalidate();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context colors
        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxNewColor_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox inpFrm = new FrmInputBox("New Color Rule", "Enter a name for the new color rule:", "New Color"))
            {
                if (inpFrm.ShowDialog() == DialogResult.OK)
                {
                    //Create obj
                    EuroText_Color colorData = new EuroText_Color
                    {
                        Name = inpFrm.ReturnValue
                    };
                    foreach (var lang in GlobalVariables.CurrentProject.Languages)
                    {
                        colorData.Words.Add(lang, string.Empty);
                    }

                    //Add obj
                    colorFile.Colors.Add(colorData);
                    lbxColours.Items.Add(inpFrm.ReturnValue);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxRemoveColor_Click(object sender, System.EventArgs e)
        {
            int index = lbxColours.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            //Ask user
            DialogResult result = MessageBox.Show("Are you sure you want to remove the selected color rule?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            //Remove from obj
            if (index < colorFile.Colors.Count)
            {
                colorFile.Colors.RemoveAt(index);
            }

            //Remove from UI
            lbxColours.Items.RemoveAt(index);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxRenameColor_Click(object sender, System.EventArgs e)
        {
            int index = lbxColours.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            if (index >= colorFile.Colors.Count)
            {
                return;
            }

            EuroText_Color colorData = colorFile.Colors[index];
            using (FrmInputBox inpFrm = new FrmInputBox("Rename Color", "Set a new name for the color", colorData.Name))
            {
                if (inpFrm.ShowDialog() == DialogResult.OK)
                {
                    string newName = inpFrm.ReturnValue;
                    if (string.IsNullOrWhiteSpace(newName))
                    {
                        return;
                    }

                    colorData.Name = newName;
                    lbxColours.Items[index] = newName;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Listbox Languages
        //-------------------------------------------------------------------------------------------------------------------------------
        private void lbxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxWords.BeginUpdate();
            lbxWords.Items.Clear();
            lbxWords.EndUpdate();

            int colorIndex = lbxColours.SelectedIndex;
            int langIndex = lbxLanguages.SelectedIndex;

            if (colorIndex < 0 || langIndex < 0)
            {
                return;
            }

            EuroText_Color colorData = colorFile.Colors[colorIndex];
            string language = lbxLanguages.Items[langIndex].ToString();

            string wordsData;
            if (!colorData.Words.TryGetValue(language, out wordsData))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(wordsData))
            {
                return;
            }

            string[] words = wordsData.Split(new[] { ';' },StringSplitOptions.RemoveEmptyEntries);

            lbxWords.BeginUpdate();
            foreach (string word in words)
            {
                lbxWords.Items.Add(word.Trim());
            }
            lbxWords.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Words
        //-------------------------------------------------------------------------------------------------------------------------------
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            int colorIndex = lbxColours.SelectedIndex;
            int langIndex = lbxLanguages.SelectedIndex;

            if (colorIndex < 0 || langIndex < 0)
                return;

            EuroText_Color colorData = colorFile.Colors[colorIndex];
            string language = lbxLanguages.Items[langIndex].ToString();

            using (FrmInputBox inpFrm = new FrmInputBox("Add Word", "Enter the word to be associated with this color:", string.Empty))
            {
                if (inpFrm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string newWord = inpFrm.ReturnValue;
                if (string.IsNullOrWhiteSpace(newWord))
                {
                    return;
                }
                newWord = newWord.Trim();

                //---------------------------------------------------------------------------------
                // Comprobar duplicados SOLO contra lo que ya está en la UI
                //---------------------------------------------------------------------------------
                foreach (var item in lbxWords.Items)
                {
                    if (string.Equals(item.ToString(), newWord, StringComparison.OrdinalIgnoreCase))
                    {
                        return; // ya existe
                    }
                }
                lbxWords.Items.Add(newWord);

                //---------------------------------------------------------------------------------
                // Reconstruir el string del modelo a partir de la UI
                //---------------------------------------------------------------------------------
                List<string> wordsList = new List<string>();
                foreach (var item in lbxWords.Items)
                {
                    wordsList.Add(item.ToString());
                }

                colorData.Words[language] = string.Join(";", wordsList);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void btnRemoveWord_Click(object sender, System.EventArgs e)
        {
            int colorIndex = lbxColours.SelectedIndex;
            int langIndex = lbxLanguages.SelectedIndex;

            if (colorIndex < 0 || langIndex < 0)
            {
                return;
            }

            if (lbxWords.SelectedItems.Count == 0)
            {
                return;
            }

            EuroText_Color colorData = colorFile.Colors[colorIndex];
            string language = lbxLanguages.Items[langIndex].ToString();

            //---------------------------------------------------------------------------------
            // Eliminar de la UI (desde atrás para no romper índices)
            //---------------------------------------------------------------------------------
            for (int i = lbxWords.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbxWords.Items.RemoveAt(lbxWords.SelectedIndices[i]);
            }

            //---------------------------------------------------------------------------------
            // Reconstruir el modelo desde la UI
            //---------------------------------------------------------------------------------
            if (lbxWords.Items.Count == 0)
            {
                // No quedan palabras
                colorData.Words[language] = string.Empty;
            }
            else
            {
                List<string> wordsList = new List<string>();
                foreach (var item in lbxWords.Items)
                {
                    wordsList.Add(item.ToString());
                }

                colorData.Words[language] = string.Join(";", wordsList);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void btnOk_Click(object sender, EventArgs e)
        {
            string colorWordsFile = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "WordsColor.etf");
            ETXML_Writter dataWriter = new ETXML_Writter();
            dataWriter.WriteWordsColorDocument(colorWordsFile, colorFile);
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
