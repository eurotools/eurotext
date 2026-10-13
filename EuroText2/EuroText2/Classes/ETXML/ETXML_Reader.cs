using System;
using System.Collections.Generic;
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
            EuroText_TextFile textObject = new EuroText_TextFile();

            // Text files are read very frequently (search, export, validation, etc.).
            // A forward-only reader avoids building an XmlDocument for every ETF file.
            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit
            };

            using (XmlReader reader = XmlReader.Create(filePath, settings))
            {
                reader.MoveToContent();
                if (reader.NodeType != XmlNodeType.Element ||
                    reader.Name != "ETXML" ||
                    !string.Equals(reader.GetAttribute("type"), "TEXTFILE", StringComparison.Ordinal))
                {
                    return textObject;
                }

                reader.Read();
                while (!reader.EOF)
                {
                    if (reader.NodeType != XmlNodeType.Element)
                    {
                        reader.Read();
                        continue;
                    }

                    switch (reader.Name)
                    {
                        case "FirstCreated":
                            textObject.FirstCreated = reader.ReadElementContentAsString();
                            continue;
                        case "CreatedBy":
                            textObject.CreatedBy = reader.ReadElementContentAsString();
                            continue;
                        case "LastModified":
                            textObject.LastModified = reader.ReadElementContentAsString();
                            continue;
                        case "LastModifiedBy":
                            textObject.LastModifiedBy = reader.ReadElementContentAsString();
                            continue;
                        case "Color":
                            textObject.RowColor = ColorTranslator.FromHtml(reader.ReadElementContentAsString());
                            continue;
                        case "Notes":
                            textObject.Notes = reader.ReadElementContentAsString();
                            continue;
                        case "Categories":
                            textObject.textFlags = Convert.ToInt32(reader.ReadElementContentAsString());
                            continue;
                        case "Group":
                            textObject.Group = reader.ReadElementContentAsString();
                            continue;
                        case "Tone":
                            textObject.Tone = reader.ReadElementContentAsString();
                            continue;
                        case "Gender":
                            textObject.Gender = reader.ReadElementContentAsString();
                            continue;
                        case "Context":
                            textObject.Context = reader.ReadElementContentAsString();
                            continue;
                        case "OutputSection":
                            textObject.OutputSection = reader.ReadElementContentAsString()
                                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        case "MaxNumOfChars":
                            textObject.MaxNumOfChars = Convert.ToInt32(reader.ReadElementContentAsString());
                            continue;
                        case "DeatText":
                            textObject.DeadText = Convert.ToInt32(reader.ReadElementContentAsString());
                            continue;
                        case "Message":
                            string currentLanguage = reader.GetAttribute("language");
                            string message = reader.ReadElementContentAsString();
                            if (!string.IsNullOrEmpty(currentLanguage) && !textObject.Messages.ContainsKey(currentLanguage))
                            {
                                textObject.Messages.Add(currentLanguage, message);
                            }
                            continue;
                        default:
                            reader.Read();
                            break;
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

        //-------------------------------------------------------------------------------------------------------------------------------
        internal EuroText_ColorFile ReadWordsColorDocument(string filePath)
        {
            EuroText_ColorFile fileData = new EuroText_ColorFile();

            using (XmlReader reader = XmlReader.Create(filePath))
            {
                EuroText_Color currentColor = null;
                while (reader.Read())
                {
                    if (reader.NodeType != XmlNodeType.Element)
                    {
                        continue;
                    }

                    switch (reader.Name)
                    {
                        //-----------------------------------------------------------------------------------------
                        // Info
                        case "FirstCreated":
                            fileData.FirstCreated = reader.ReadElementContentAsString();
                            break;

                        case "CreatedBy":
                            fileData.CreatedBy = reader.ReadElementContentAsString();
                            break;

                        case "LastModified":
                            fileData.LastModified = reader.ReadElementContentAsString();
                            break;

                        case "LastModifiedBy":
                            fileData.LastModifiedBy = reader.ReadElementContentAsString();
                            break;

                        //-----------------------------------------------------------------------------------------
                        // Color
                        case "Color":
                            currentColor = new EuroText_Color();
                            currentColor.Name = reader.GetAttribute("name");

                            int r = ReadIntAttr(reader, "r");
                            int g = ReadIntAttr(reader, "g");
                            int b = ReadIntAttr(reader, "b");

                            currentColor.WordColor = Color.FromArgb(r, g, b);
                            currentColor.Words = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

                            fileData.Colors.Add(currentColor);
                            break;

                        //-----------------------------------------------------------------------------------------
                        // Language
                        case "Language":
                            if (currentColor != null)
                            {
                                string langId = reader.GetAttribute("id");
                                string words = reader.ReadElementContentAsString();

                                if (!string.IsNullOrEmpty(langId))
                                {
                                    currentColor.Words[langId] = words;
                                }
                            }
                            break;
                    }
                }
            }

            return fileData;
        }

        private int ReadIntAttr(XmlReader reader, string attrName)
        {
            int value;
            if (int.TryParse(reader.GetAttribute(attrName), out value))
                return value;

            return 0;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
