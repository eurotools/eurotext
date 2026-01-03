using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMainTextEditor : Form
    {
        private int indexTest = 0;
        private bool ResetSettingsOnExit;
        private readonly string filePath;
        private readonly List<UserControl_TextEditor> m_DockForms = new List<UserControl_TextEditor>();
        private EuroText_TextFile objText;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmMainTextEditor(string textFilePath)
        {
            InitializeComponent();
            filePath = textFilePath;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMainTextEditor_Load(object sender, System.EventArgs e)
        {
            Text = Path.GetFileNameWithoutExtension(filePath);

            //New object
            ETXML_Reader filesReader = new ETXML_Reader();
            objText = filesReader.ReadTextFile(filePath);
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf"));

            //Get all groups
            CommonFunctions.GroupsToCombobox(Combobox_Group);
            CommonFunctions.AddArrayToCombobox(cbxTextContext, GlobalVariables.CurrentProject.Contexts.ToArray());
            CommonFunctions.AddArrayToCombobox(cbxGender, GlobalVariables.CurrentProject.Genders.ToArray());
            CommonFunctions.AddArrayToCombobox(cbxTone, GlobalVariables.CurrentProject.Tones.ToArray());

            //Group and Output Section
            Combobox_Group.SelectedItem = objText.Group;
            List<string> outputSections = new List<string>();
            for (int i = 0; i < objText.OutputSection.Length; i++)
            {
                if (sectionsFileText.TextSections.ContainsKey(objText.OutputSection[i]))
                {
                    outputSections.Add(sectionsFileText.TextSections[objText.OutputSection[i]]);
                }
            }
            Textbox_OutputSections.Text = string.Join(";", outputSections.ToArray());

            //Info
            cbxGender.SelectedItem = objText.Gender;
            cbxTextContext.SelectedItem = objText.Context;
            cbxTone.SelectedItem = objText.Tone;

            //Others
            CheckBox_TextDead.Checked = Convert.ToBoolean(objText.DeadText);
            Numeric_MaxChars.Value = objText.MaxNumOfChars;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMainTextEditor_Shown(object sender, EventArgs e)
        {
            //Add notes
            AddNewForm("Notes", objText.Notes);

            //Add languages Stuff
            if (GlobalVariables.CurrentProject.Languages.Count > 0)
            {
                foreach (string currentLanguage in GlobalVariables.CurrentProject.Languages)
                {
                    string textToDisplay = string.Empty;
                    if (objText.Messages.ContainsKey(currentLanguage))
                    {
                        textToDisplay = objText.Messages[currentLanguage];
                    }
                    AddNewForm(currentLanguage, textToDisplay);
                }
            }

            //Load Panels State
            if (File.Exists("ET\\Dock Settings Text Editor.xml"))
            {
                dockPanel.LoadFromXml("ET\\Dock Settings Text Editor.xml", new DeserializeDockContent(DeserializeDockContent));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMainTextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextsModified())
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    CloseTextEditor();
                }
            }
            else
            {
                CloseTextEditor();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal IDockContent DeserializeDockContent(string persistString)
        {
            if (indexTest < m_DockForms.Count)
            {
                if (persistString == m_DockForms[indexTest].GetType().ToString())
                {
                    return m_DockForms[indexTest++];
                }
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_OutputSections_Click(object sender, EventArgs e)
        {
            FrmTextOutSection outForm = new FrmTextOutSection(Textbox_OutputSections.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            if (outForm.ShowDialog() == DialogResult.OK)
            {
                Textbox_OutputSections.Text = outForm.selectedSections;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  MENU ITEM FILE
        //-------------------------------------------------------------------------------------------
        private void MenuItemStrip_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_ResetSettings_Click(object sender, EventArgs e)
        {
            ResetSettingsOnExit = true;
            MessageBox.Show("Settings will be reset the next time that you open this editor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_Windows_DropDownOpening(object sender, EventArgs e)
        {
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------
        //  FORM BUTTONS EVENTS
        //-------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            SaveFile();
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------
        //  FUNCTIONS
        //-------------------------------------------------------------------------------------------
        private void SaveFile()
        {
            ETXML_Reader filesReader = new ETXML_Reader();
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(textSectionsFilePath);

            //Update text
            for (int i = 0; i < m_DockForms.Count; i++)
            {
                //Get message data
                string language = m_DockForms[i].Text;
                string messageData = m_DockForms[i].Textbox.Text;

                if (m_DockForms[i].Name.Equals("Frm_Notes"))
                {
                    objText.Notes = messageData;
                }
                else
                {
                    //Update controls
                    if (objText.Messages.ContainsKey(language))
                    {
                        objText.Messages[language] = messageData;
                    }
                    else
                    {
                        objText.Messages.Add(language, messageData);
                    }
                }
            }

            //Group and Output Section
            if (Combobox_Group.SelectedItem != null)
            {
                objText.Group = Combobox_Group.SelectedItem.ToString();
            }

            //Others
            objText.DeadText = Convert.ToInt32(CheckBox_TextDead.Checked);
            objText.MaxNumOfChars = (int)Numeric_MaxChars.Value;
            string[] outputSections = Textbox_OutputSections.Text.Split(';');
            objText.OutputSection = new string[outputSections.Length];
            for (int i = 0; i < outputSections.Length; i++)
            {
                objText.OutputSection[i] = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == outputSections[i]).Key;
            }

            //info
            if (cbxTextContext.SelectedItem != null)
            {
                objText.Context = cbxTextContext.SelectedItem.ToString();
            }

            if (cbxTone.SelectedItem != null)
            {
                objText.Tone = cbxTone.SelectedItem.ToString();
            }

            if (cbxGender.SelectedItem != null)
            {
                objText.Gender = cbxGender.SelectedItem.ToString();
            }

            //Update properties and listview
            objText.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            objText.LastModifiedBy = GlobalVariables.EuroTextUser;

            ETXML_Writter filesWriter = new ETXML_Writter();
            filesWriter.WriteTextFile(filePath, objText);
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private bool TextsModified()
        {
            bool ObjectsModified = false;

            //Update text
            for (int i = 0; i < m_DockForms.Count; i++)
            {
                //Get message data
                string language = m_DockForms[i].Text;
                string messageData = m_DockForms[i].Textbox.Text;

                if (m_DockForms[i].Name.Equals("Frm_Notes"))
                {
                    objText.Notes = messageData;
                }
                else
                {
                    //Update controls
                    if (objText.Messages.ContainsKey(language))
                    {
                        if (!objText.Messages[language].Equals(messageData))
                        {
                            ObjectsModified = true;
                            break;
                        }
                    }
                }
            }

            return ObjectsModified;
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void AddNewForm(string formName, string tabText)
        {
            //Add Menu Item
            ToolStripMenuItem formMenuItem = new ToolStripMenuItem
            {
                Name = "MenuItem_Frm_" + formName,
                Text = formName,
                Checked = true
            };
            MenuItemStrip_Windows.DropDownItems.Add(formMenuItem);
            formMenuItem.Click += (s, e) => OpenForm(s, e);

            //Create a new form
            UserControl_TextEditor notesEditor = new UserControl_TextEditor()
            {
                Text = formName,
                TabText = formName,
                Name = string.Format("Frm_{0}", formName)
            };
            notesEditor.Textbox.Text = tabText;

            //Add form to this list
            m_DockForms.Add(notesEditor);
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void OpenForm(object sender, EventArgs args)
        {
            foreach (DockContent formToShow in m_DockForms)
            {
                string senderName = string.Format("Frm_{0}", sender);
                if (formToShow.Name.Equals(senderName))
                {
                    formToShow.Show(dockPanel, DockState.Float);
                    break;
                }
            }
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UpdateWindowMenuChecks()
        {
            foreach (DockContent formToCheck in m_DockForms)
            {
                string formName = formToCheck.Name;
                foreach (ToolStripMenuItem menuItem in MenuItemStrip_Windows.DropDownItems)
                {
                    string senderName = string.Format("Frm_{0}", menuItem.Text);
                    if (formName.Equals(senderName))
                    {
                        menuItem.Checked = formToCheck.DockState != DockState.Hidden;
                        break;
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CloseTextEditor()
        {
            //Save Dock Panels status
            dockPanel.SaveAsXml("ET\\Dock Settings Text Editor.xml");

            //Close all forms
            foreach (Form dockForm in m_DockForms)
            {
                dockForm.Close();
            }

            //Reset Settings
            if (ResetSettingsOnExit)
            {
                File.Delete("ET\\Dock Settings Text Editor.xml");
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
