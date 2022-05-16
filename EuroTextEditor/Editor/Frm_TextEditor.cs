using System;
using System.Collections.Generic;
using System.IO;
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
        private UserControl_TextEditor[] languageEditors;
        private int languageEditorsIndex = 0;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor(string textFilePath, ListViewItem objectToModify)
        {
            InitializeComponent();
            filePath = textFilePath;
            listViewItemMainForm = objectToModify;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Load(object sender, EventArgs e)
        {
            //Get all groups
            string textGroupsFileText = @"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\Groups.txt";
            if (File.Exists(textGroupsFileText))
            {
                string[] textGroup = File.ReadAllLines(textGroupsFileText);
                Combobox_Group.BeginUpdate();
                Combobox_Group.Items.Add("");
                Combobox_Group.Items.AddRange(textGroup);
                Combobox_Group.EndUpdate();
                if (Combobox_Group.Items.Count > 0)
                {
                    Combobox_Group.SelectedIndex = 0;
                }
            }

            //Get all output levels and sections
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                Dictionary<string, string> sectionsAndLevels = new Dictionary<string, string> { { "", "" } };
                foreach (KeyValuePair<string, string> entry in sectionsFileText.TextSections)
                {
                    sectionsAndLevels.Add(entry.Key, entry.Value);
                }
                Combobox_OutputSection.DataSource = new BindingSource(sectionsAndLevels, null);
                Combobox_OutputSection.DisplayMember = "Value";
                Combobox_OutputSection.ValueMember = "Key";
            }

            //New object
            ETXML_Reader filesReader = new ETXML_Reader();
            objText = filesReader.ReadTextFile(filePath);

            //Group and Output Section
            Combobox_Group.SelectedItem = objText.Group;
            Combobox_OutputSection.SelectedValue = objText.OutputSection;

            //Others
            CheckBox_TextDead.Checked = Convert.ToBoolean(objText.DeadText);
            Numeric_MaxChars.Value = objText.MaxNumOfChars;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Shown(object sender, EventArgs e)
        {
            if (GlobalVariables.CurrentProject.Languages.Count > 0)
            {
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsTextEditor.xml");
                languageEditors = new UserControl_TextEditor[GlobalVariables.CurrentProject.Languages.Count];
                for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                {
                    string currentLanguage = GlobalVariables.CurrentProject.Languages[i];

                    //Add menu item
                    MenuItem newMenuItem = MenuItem_Windows.MenuItems.Add(currentLanguage);
                    newMenuItem.Name = "MenuItem_Frm_" + currentLanguage;
                    newMenuItem.Checked = true;

                    //Create a new language editor
                    UserControl_TextEditor newLangEditor = new UserControl_TextEditor(newMenuItem)
                    {
                        Text = currentLanguage,
                        TabText = currentLanguage,
                        Name = "Frm_" + currentLanguage
                    };

                    //Add text to this language editor
                    if (objText.Messages.ContainsKey(currentLanguage))
                    {
                        newLangEditor.Textbox.Text = objText.Messages[currentLanguage];
                    }

                    languageEditors[i] = newLangEditor;
                    if (!File.Exists(configFile))
                    {
                        newLangEditor.Show(dockPanel, DockState.Document);
                    }
                }

                //Show forms
                if (File.Exists(configFile))
                {
                    DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
                    dockPanel.LoadFromXml(configFile, _deserializeDockContent);
                }

                //Update menus
                for (int i = 0; i < languageEditors.Length; i++)
                {
                    if (languageEditors[i] != null && languageEditors[i].IsHidden)
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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (languageEditorsIndex < languageEditors.Length)
            {
                if (persistString == typeof(UserControl_TextEditor).ToString())
                {
                    return languageEditors[languageEditorsIndex++];
                }
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dock conifg
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsTextEditor.xml");
            dockPanel.SaveAsXml(configFile);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ResetPanels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < languageEditors.Length; i++)
            {
                //Update properties
                languageEditors[i].IsFloat = false;
                languageEditors[i].IsHidden = false;
                languageEditors[i].Pane = dockPanel.Panes[0];
                languageEditors[i].Show(dockPanel, DockState.Document);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Update text
            for (int i = 0; i < languageEditors.Length; i++)
            {
                //Get message data
                string language = languageEditors[i].Text;
                string messageData = languageEditors[i].Textbox.Text;

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

            //Group and Output Section
            if (Combobox_Group.SelectedItem != null)
            {
                objText.Group = Combobox_Group.SelectedItem.ToString();
            }
            if (Combobox_OutputSection.SelectedValue != null)
            {
                objText.OutputSection = Combobox_OutputSection.SelectedValue.ToString();
            }

            //Others
            objText.DeadText = Convert.ToInt32(CheckBox_TextDead.Checked);
            objText.MaxNumOfChars = (int)Numeric_MaxChars.Value;

            //Update properties and listview
            objText.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            objText.LastModifiedBy = GlobalVariables.EuroTextUser;
            listViewItemMainForm.SubItems[3].Text = objText.LastModified;
            listViewItemMainForm.SubItems[4].Text = objText.LastModifiedBy;

            ETXML_Writter filesWriter = new ETXML_Writter();
            filesWriter.WriteTextFile(filePath, objText);

            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
