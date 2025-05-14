using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class ETXML_Reader
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal EuroText_TextFile ReadTextFile(string filePath)
        {
            //Create a text object
            EuroText_TextFile textObject = new EuroText_TextFile();

            //Create reader
            XmlDocument reader = new XmlDocument();
            reader.Load(filePath);

            //Ensure that is a valid file
            if (reader.DocumentElement.Attributes["type"].Value.Equals("TEXTFILE"))
            {
                //Read Basic Info
                XmlNodeList infoNodes = reader.SelectNodes("ETXML/Info/*");
                foreach (XmlNode node in infoNodes)
                {
                    switch (node.Name)
                    {
                        case "FirstCreated":
                            textObject.FirstCreated = node.InnerText;
                            break;
                        case "CreatedBy":
                            textObject.CreatedBy = node.InnerText;
                            break;
                        case "LastModified":
                            textObject.LastModified = node.InnerText;
                            break;
                        case "LastModifiedBy":
                            textObject.LastModifiedBy = node.InnerText;
                            break;
                    }
                }

                //Read Basic Info
                XmlNodeList rowInfoNodes = reader.SelectNodes("ETXML/RowInfo/*");
                foreach (XmlNode node in rowInfoNodes)
                {
                    switch (node.Name)
                    {
                        case "Color":
                            textObject.RowColor = ColorTranslator.FromHtml(node.InnerText);
                            break;
                        case "Notes":
                            textObject.Notes = node.InnerText;
                            break;
                        case "Categories":
                            textObject.textFlags = Convert.ToInt32(node.InnerText);
                            break;
                    }
                }

                //Read parameters section
                XmlNodeList paremetersNodes = reader.SelectNodes("ETXML/Properties/*");
                foreach (XmlNode node in paremetersNodes)
                {
                    switch (node.Name)
                    {
                        case "Group":
                            textObject.Group = node.InnerText;
                            break;
                        case "Tone":
                            textObject.Tone = node.InnerText;
                            break;
                        case "Gender":
                            textObject.Gender = node.InnerText;
                            break;
                        case "Context":
                            textObject.Context = node.InnerText;
                            break;
                        case "OutputSection":
                            textObject.OutputSection = node.InnerText.Split(';');
                            break;
                        case "MaxNumOfChars":
                            textObject.MaxNumOfChars = Convert.ToInt32(node.InnerText);
                            break;
                        case "DeatText":
                            textObject.DeadText = Convert.ToInt32(node.InnerText);
                            break;
                    }
                }

                //Read messages language section
                XmlNodeList messagesNdoes = reader.SelectNodes("ETXML/Messages/*");
                foreach (XmlNode node in messagesNdoes)
                {
                    string currentLanguage = node.Attributes["language"].Value;
                    if (!textObject.Messages.ContainsKey(currentLanguage))
                    {
                        textObject.Messages.Add(currentLanguage, node.InnerText);
                    }
                }
            }

            return textObject;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal EuroText_ProjectFile ReadProjectFile(string projectFilePath)
        {
            //Create project file
            EuroText_ProjectFile projData = new EuroText_ProjectFile();

            //Create reader
            XmlDocument reader = new XmlDocument();
            reader.Load(projectFilePath);

            //Ensure that is a valid file
            if (reader.DocumentElement.Attributes["type"].Value.Equals("PROJECTFILE"))
            {
                //Read Basic Info
                XmlNodeList infoNodes = reader.SelectNodes("ETXML/Info/*");
                foreach (XmlNode node in infoNodes)
                {
                    switch (node.Name)
                    {
                        case "FirstCreated":
                            projData.FirstCreated = node.InnerText;
                            break;
                        case "CreatedBy":
                            projData.CreatedBy = node.InnerText;
                            break;
                        case "LastModified":
                            projData.LastModified = node.InnerText;
                            break;
                        case "LastModifiedBy":
                            projData.LastModifiedBy = node.InnerText;
                            break;
                    }
                }

                //Read parameters section
                XmlNodeList paremetersNodes = reader.SelectNodes("ETXML/Properties/*");
                foreach (XmlNode node in paremetersNodes)
                {
                    switch (node.Name)
                    {
                        case "MessagesDirectory":
                            projData.MessagesDirectory = node.InnerText;
                            break;
                        case "SpreadSheetsDirectory":
                            projData.SpreadSheetsDirectory = node.InnerText;
                            break;
                        case "ELHashCodesServerPath":
                            projData.EuroLandHahCodesServPath = node.InnerText;
                            break;
                        case "UnusedTextBit":
                            projData.UnusedTextBit = Convert.ToInt32(node.InnerText);
                            break;
                    }
                }

                //Read messages language section
                XmlNodeList languagesNodes = reader.SelectNodes("ETXML/Languages/*");
                foreach (XmlNode node in languagesNodes)
                {
                    projData.Languages.Add(node.InnerText);
                }

                //Read Categories section
                XmlNodeList categoryNodes = reader.SelectNodes("ETXML/Categories/*");
                foreach (XmlNode node in categoryNodes)
                {
                    projData.Categories.Add(node.InnerText);
                }

                // Read Tones section
                XmlNodeList toneNodes = reader.SelectNodes("ETXML/Tones/*");
                foreach (XmlNode node in toneNodes)
                {
                    projData.Tones.Add(node.InnerText);
                }

                // Read Genders section
                XmlNodeList genderNodes = reader.SelectNodes("ETXML/Genders/*");
                foreach (XmlNode node in genderNodes)
                {
                    projData.Genders.Add(node.InnerText);
                }

                // Read Contexts section
                XmlNodeList contextNodes = reader.SelectNodes("ETXML/Contexts/*");
                foreach (XmlNode node in contextNodes)
                {
                    projData.Contexts.Add(node.InnerText);
                }
            }

            return projData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal EuroText_TextSections ReadTextSectionsFile(string projectFilePath)
        {
            //Create project file
            EuroText_TextSections projData = new EuroText_TextSections();

            //Create reader
            XmlDocument reader = new XmlDocument();
            reader.Load(projectFilePath);

            //Ensure that is a valid file
            if (reader.DocumentElement.Attributes["type"].Value.Equals("TEXTSECTIONSFILE"))
            {
                //Read Basic Info
                XmlNodeList infoNodes = reader.SelectNodes("ETXML/Info/*");
                foreach (XmlNode node in infoNodes)
                {
                    switch (node.Name)
                    {
                        case "FirstCreated":
                            projData.FirstCreated = node.InnerText;
                            break;
                        case "CreatedBy":
                            projData.CreatedBy = node.InnerText;
                            break;
                        case "LastModified":
                            projData.LastModified = node.InnerText;
                            break;
                        case "LastModifiedBy":
                            projData.LastModifiedBy = node.InnerText;
                            break;
                    }
                }

                //Read parameters section
                XmlNodeList paremetersNodes = reader.SelectNodes("ETXML/TextSections/*");
                foreach (XmlNode node in paremetersNodes)
                {
                    int maxId = Convert.ToInt32(Regex.Match(node.Attributes["sectionNumber"].Value, @"\d+").Value);
                    projData.TextSections.Add("HT_TextSection" + maxId.ToString("00"), node.InnerText);
                    GlobalVariables.CurrentProject.TextSectionsID = Math.Max(GlobalVariables.CurrentProject.TextSectionsID, maxId);
                }
            }

            return projData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal EuroText_TextGroups ReadTextGroupsFile(string projectFilePath)
        {
            //Create project file
            EuroText_TextGroups projData = new EuroText_TextGroups();

            //Create reader
            XmlDocument reader = new XmlDocument();
            reader.Load(projectFilePath);

            //Ensure that is a valid file
            if (reader.DocumentElement.Attributes["type"].Value.Equals("TEXTGROUPSFILE"))
            {
                //Read Basic Info
                XmlNodeList infoNodes = reader.SelectNodes("ETXML/Info/*");
                foreach (XmlNode node in infoNodes)
                {
                    switch (node.Name)
                    {
                        case "FirstCreated":
                            projData.FirstCreated = node.InnerText;
                            break;
                        case "CreatedBy":
                            projData.CreatedBy = node.InnerText;
                            break;
                        case "LastModified":
                            projData.LastModified = node.InnerText;
                            break;
                        case "LastModifiedBy":
                            projData.LastModifiedBy = node.InnerText;
                            break;
                    }
                }

                //Read parameters section
                XmlNodeList paremetersNodes = reader.SelectNodes("ETXML/TextGroups/*");
                foreach (XmlNode node in paremetersNodes)
                {
                    projData.TextGroups.Add(node.InnerText);
                }
            }

            return projData;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
