using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class CommonFunctions
    {
        //-------------------------------------------------------------------------------------------
        //  HASHTABLES
        //-------------------------------------------------------------------------------------------
        internal static HashSet<string> ReadHashTableSection(string hashTableFilePath, string hashTableSection)
        {
            HashSet<string> AvailableHashCodes = new HashSet<string>();
            using (StreamReader file = new StreamReader(hashTableFilePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Contains(hashTableSection))
                    {
                        Match regexMatch = Regex.Match(ln, @"#define\s(\w+)");
                        if (regexMatch.Length > 0)
                        {
                            AvailableHashCodes.Add(regexMatch.Groups[1].Value);
                        }
                    }
                }
                file.Close();
            }

            return AvailableHashCodes;
        }

        //-------------------------------------------------------------------------------------------
        //  USERNAME
        //-------------------------------------------------------------------------------------------
        internal static string AskForUserName(string defaultName)
        {
            string inputUserName = defaultName;

            do
            {
                Frm_InputBox textInfo = new Frm_InputBox("Enter UserName.", "Please enter your username.", "");
                if (textInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    inputUserName = textInfo.ReturnValue;
                }
            } while (string.IsNullOrEmpty(inputUserName));

            return inputUserName;
        }

        //-------------------------------------------------------------------------------------------
        //  MULTIPLE DELETION
        //-------------------------------------------------------------------------------------------
        internal static string MultipleDeletionMessage(string messageToShow, string[] itemsToDelete)
        {
            int maxItemsToShow = 33;

            //Create message to inform user
            string filesListToDelete = messageToShow + Environment.NewLine + Environment.NewLine;
            int numItems = Math.Min(maxItemsToShow, itemsToDelete.Length);
            for (int i = 0; i < numItems; i++)
            {
                filesListToDelete += "'" + itemsToDelete[i] + "'" + Environment.NewLine;
            }
            if (itemsToDelete.Length > maxItemsToShow)
            {
                filesListToDelete += "Plus Some More ....." + Environment.NewLine;
                filesListToDelete += "............" + Environment.NewLine;
            }
            filesListToDelete += Environment.NewLine + "Total Files: " + itemsToDelete.Length;
            return filesListToDelete;
        }

        //-------------------------------------------------------------------------------------------
        //  OBJECTS
        //-------------------------------------------------------------------------------------------
        internal static void EditHashCode(ListViewItem itemToModify, Frm_ListBoxHashCodes parentFormToSync)
        {
            string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToModify.Text + ".etf");
            if (!File.Exists(textFilePath))
            {
                DialogResult answer = MessageBox.Show(string.Join(" ", "", "Source file not found:", textFilePath, "\n\nDo you want to create it now?"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    //Create object
                    EuroText_TextFile newTextFile = new EuroText_TextFile();

                    //Write Object
                    ETXML_Writter filesWriter = new ETXML_Writter();
                    filesWriter.WriteTextFile(textFilePath, newTextFile);
                }
            }

            //Show form
            if (File.Exists(textFilePath))
            {
                Frm_TextEditor textEditor = new Frm_TextEditor(textFilePath, itemToModify, parentFormToSync)
                {
                    Text = itemToModify.Text
                };
                textEditor.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  FORMS
        //-------------------------------------------------------------------------------------------
        internal static bool FormIsOpened(string formName)
        {
            bool formOpened = false;

            //Check if the form is already opened
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name.Equals(formName))
                {
                    frm.Focus();
                    formOpened = true;
                    break;
                }
            }

            return formOpened;
        }

        //-------------------------------------------------------------------------------------------
        //  FLAGS
        //-------------------------------------------------------------------------------------------
        internal static string GetFlagsLabels(int flags)
        {
            string flagsLabels = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                if (Convert.ToBoolean((flags >> i) & 1))
                {
                    string label = string.Empty;
                    if (i < GlobalVariables.CurrentProject.Categories.Count)
                    {
                        label = GlobalVariables.CurrentProject.Categories[i];
                    }
                    flagsLabels += label + " | ";
                }
            }

            return flagsLabels.Trim().TrimEnd('|').Trim();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
