﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ListBox_TextGroups : DockContent
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextGroups()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextGroups_Load(object sender, EventArgs e)
        {
            //Get text file path
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt");
            if (File.Exists(textGroupsFilePath))
            {
                ListBox_TextGroups.BeginUpdate();
                ListBox_TextGroups.Items.AddRange(File.ReadAllLines(textGroupsFilePath));
                ListBox_TextGroups.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX TEXTGROUPS
        //-------------------------------------------------------------------------------------------
        private void ListBox_TextGroups_MouseDoubleClick(object sender, EventArgs e)
        {
            OpenHashCodesGroup();
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_NewGroup_Click(object sender, EventArgs e)
        {
            using (Frm_InputBox newGroupForm = new Frm_InputBox("Create New", "Enter Name", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    //Format the name
                    string newGroupName = newGroupForm.ReturnValue.ToUpper().Trim();
                    if (!newGroupName.StartsWith("M_"))
                    {
                        newGroupName = string.Join("", "M_", newGroupName);
                    }

                    //Add the group to the list
                    if (!ListBox_TextGroups.Items.Contains(newGroupName))
                    {
                        ListBox_TextGroups.Items.Add(newGroupName);

                        //Get text file path
                        string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt");
                        if (File.Exists(textGroupsFilePath))
                        {
                            //Update txt
                            string[] clist = ListBox_TextGroups.Items.OfType<string>().ToArray();
                            File.WriteAllLines(textGroupsFilePath, clist);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new group could not be added, a group with the same name already exists.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------
        //  FUNCTIONS
        //-------------------------------------------------------------------------------------------
        private void OpenHashCodesGroup()
        {
            if (ListBox_TextGroups.SelectedItems.Count == 1)
            {
                HashSet<string> hashCodesInThisGroup = new HashSet<string>();
                string groupToSearch = ListBox_TextGroups.SelectedItem.ToString();

                //Search hashcodes that are in this group
                string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly).Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
                for (int i = 0; i < filesToAdd.Length; i++)
                {
                    //Get message text and ensure that the source file exists
                    string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", filesToAdd[i] + ".etf");
                    if (File.Exists(filePath))
                    {
                        //Read object
                        ETXML_Reader filesReader = new ETXML_Reader();
                        EuroText_TextFile objText = filesReader.ReadTextFile(filePath);

                        //Add items
                        if (objText.Group.Equals(groupToSearch))
                        {
                            hashCodesInThisGroup.Add(filesToAdd[i].ToString());
                        }
                    }
                }

                //Show form
                Frm_GroupsViewer groupsViewer = new Frm_GroupsViewer(hashCodesInThisGroup.ToArray())
                {
                    Text = groupToSearch
                };
                groupsViewer.ShowDialog();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}