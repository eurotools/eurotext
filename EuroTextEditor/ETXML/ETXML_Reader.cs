using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml;

namespace EuroTextEditor
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
                        case "OutputSection":
                            textObject.OutputSection = node.InnerText;
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
                    textObject.Messages.Add(node.Attributes["language"].Value, node.InnerText);
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
                    }
                }

                //Read messages language section
                XmlNodeList languagesNodes = reader.SelectNodes("ETXML/Languages/*");
                foreach (XmlNode node in languagesNodes)
                {
                    projData.Languages.Add(node.InnerText);
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
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
