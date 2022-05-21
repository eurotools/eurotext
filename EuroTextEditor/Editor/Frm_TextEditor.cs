using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextEditor : Form
    {
        private readonly string filePath;
        private readonly ListViewItem listViewItemMainForm;
        private EuroText_TextFile objText;
        private List<UserControl_TextEditor> languageEditors;
        private int languageEditorsIndex = 0;
        private bool PromptSave = true;
        private readonly string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsTextEditor.xml");
        private readonly Frm_ListBoxHashCodes parentFormToSync;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor(string textFilePath, ListViewItem objectToModify, Frm_ListBoxHashCodes formToSync)
        {
            InitializeComponent();
            filePath = textFilePath;
            listViewItemMainForm = objectToModify;
            parentFormToSync = formToSync;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Load(object sender, EventArgs e)
        {
            //New object
            ETXML_Reader filesReader = new ETXML_Reader();
            objText = filesReader.ReadTextFile(filePath);
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf"));

            //Group and Output Section
            UserControl_TextOptions.Combobox_Group.SelectedItem = objText.Group;
            List<string> outputSections = new List<string>();
            for (int i = 0; i < objText.OutputSection.Length; i++)
            {
                if (sectionsFileText.TextSections.ContainsKey(objText.OutputSection[i]))
                {
                    outputSections.Add(sectionsFileText.TextSections[objText.OutputSection[i]]);
                }
            }
            UserControl_TextOptions.Textbox_OutputSections.Text = string.Join(";", outputSections.ToArray());

            //Others
            UserControl_TextOptions.CheckBox_TextDead.Checked = Convert.ToBoolean(objText.DeadText);
            UserControl_TextOptions.Numeric_MaxChars.Value = objText.MaxNumOfChars;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptSave)
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Shown(object sender, EventArgs e)
        {
            languageEditors = new List<UserControl_TextEditor>();

            //Add notes
            AddNewForm("Notes", objText.Notes);

            //Add languages Stuff
            if (GlobalVariables.CurrentProject.Languages.Count > 0)
            {
                for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                {
                    string currentLanguage = GlobalVariables.CurrentProject.Languages[i];

                    string textToDisplay = string.Empty;
                    if (objText.Messages.ContainsKey(currentLanguage))
                    {
                        textToDisplay = objText.Messages[currentLanguage];
                    }

                    AddNewForm(currentLanguage, textToDisplay);
                }
            }

            //Show forms
            if (File.Exists(configFile))
            {
                DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
                dockPanel.LoadFromXml(configFile, _deserializeDockContent);
            }

            //Update menus
            for (int i = 0; i < languageEditors.Count; i++)
            {
                if (languageEditors[i].IsHidden)
                {
                    for (int j = 0; j < MenuItem_Windows.MenuItems.Count; j++)
                    {
                        if (MenuItem_Windows.MenuItems[j].Name.Equals("MenuItem_" + languageEditors[i].Name))
                        {
                            MenuItem_Windows.MenuItems[j].Checked = false;
                            languageEditors[i].DockPanel = dockPanel;
                            break;
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (languageEditorsIndex < languageEditors.Count)
            {
                if (persistString == typeof(UserControl_TextEditor).ToString())
                {
                    return languageEditors[languageEditorsIndex++];
                }
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Dock conifg
            dockPanel.SaveAsXml(configFile);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ResetPanels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < languageEditors.Count; i++)
            {
                //Update properties
                languageEditors[i].IsFloat = false;
                languageEditors[i].IsHidden = false;
                languageEditors[i].Pane = dockPanel.Panes[0];
                languageEditors[i].Show(dockPanel, DockState.Document);
            }
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            PromptSave = false;
            SaveFile();
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void AddNewForm(string formName, string tabText)
        {
            //Add notes
            MenuItem formMenuItem = MenuItem_Windows.MenuItems.Add(formName);
            formMenuItem.Name = "MenuItem_Frm_" + formName;
            formMenuItem.Checked = true;

            //Create a new language editor
            UserControl_TextEditor notesEditor = new UserControl_TextEditor(formMenuItem, dockPanel, DockState.Document)
            {
                Text = formName,
                TabText = formName,
                Name = "Frm_" + formName
            };

            //Add text to this language editor
            notesEditor.Textbox.Text = tabText;

            languageEditors.Add(notesEditor);
            if (!File.Exists(configFile))
            {
                notesEditor.Show(dockPanel, DockState.Document);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SaveFile()
        {
            ETXML_Reader filesReader = new ETXML_Reader();
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(textSectionsFilePath);

            //Update text
            for (int i = 0; i < languageEditors.Count; i++)
            {
                //Get message data
                string language = languageEditors[i].Text;
                string messageData = languageEditors[i].Textbox.Text;

                if (languageEditors[i].Name.Equals("Frm_Notes"))
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
            if (UserControl_TextOptions.Combobox_Group.SelectedItem != null)
            {
                objText.Group = UserControl_TextOptions.Combobox_Group.SelectedItem.ToString();
            }

            //Others
            objText.DeadText = Convert.ToInt32(UserControl_TextOptions.CheckBox_TextDead.Checked);
            objText.MaxNumOfChars = (int)UserControl_TextOptions.Numeric_MaxChars.Value;
            string[] outputSections = UserControl_TextOptions.Textbox_OutputSections.Text.Split(';');
            objText.OutputSection = new string[outputSections.Length];
            for (int i = 0; i < outputSections.Length; i++)
            {
                objText.OutputSection[i] = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == outputSections[i]).Key;
            }

            //Update properties and listview
            objText.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            objText.LastModifiedBy = GlobalVariables.EuroTextUser;
            listViewItemMainForm.SubItems[3].Text = objText.LastModified;
            listViewItemMainForm.SubItems[4].Text = objText.LastModifiedBy;
            listViewItemMainForm.SubItems[6].Text = objText.Notes;

            //Sync listviews
            if (parentFormToSync != null)
            {
                foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                {
                    if (itemsToUpdate.Text.Equals(Text))
                    {
                        itemsToUpdate.SubItems[3].Text = objText.LastModified;
                        itemsToUpdate.SubItems[4].Text = objText.LastModifiedBy;
                        itemsToUpdate.SubItems[6].Text = objText.Notes;
                        break;
                    }
                }
            }

            ETXML_Writter filesWriter = new ETXML_Writter();
            filesWriter.WriteTextFile(filePath, objText);
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
