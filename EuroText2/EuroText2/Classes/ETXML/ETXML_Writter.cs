﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class ETXML_Writter
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void WriteTextFile(string filepath, EuroText_TextFile textObj)
        {
            try
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();

                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter textWriter = XmlWriter.Create(filepath, settings);
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("ETXML");
                textWriter.WriteAttributeString("type", "TEXTFILE");
                textWriter.WriteAttributeString("version", "1.0.0");
                textWriter.WriteStartElement("Info");
                textWriter.WriteElementString("FirstCreated", textObj.FirstCreated);
                textWriter.WriteElementString("CreatedBy", textObj.CreatedBy);
                textWriter.WriteElementString("LastModified", textObj.LastModified);
                textWriter.WriteElementString("LastModifiedBy", textObj.LastModifiedBy);
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("RowInfo");
                textWriter.WriteElementString("Color", ColorTranslator.ToHtml(textObj.RowColor));
                textWriter.WriteElementString("Notes", textObj.Notes);
                textWriter.WriteElementString("Categories", textObj.textFlags.ToString());
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("Properties");
                textWriter.WriteElementString("Group", textObj.Group);
                textWriter.WriteElementString("Tone", textObj.Tone);
                textWriter.WriteElementString("Context", textObj.Context);
                textWriter.WriteElementString("Gender", textObj.Gender);
                textWriter.WriteElementString("OutputSection", string.Join(";", textObj.OutputSection));
                textWriter.WriteElementString("MaxNumOfChars", textObj.MaxNumOfChars.ToString());
                textWriter.WriteElementString("DeatText", textObj.DeadText.ToString());
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("Messages");
                foreach (KeyValuePair<string, string> messageToPrint in textObj.Messages)
                {
                    textWriter.WriteStartElement("Message");
                    textWriter.WriteAttributeString("language", messageToPrint.Key);
                    textWriter.WriteCData(messageToPrint.Value);
                    textWriter.WriteEndElement();
                }

                textWriter.WriteEndDocument();
                textWriter.Close();
            }
            catch
            {

            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void WriteProjectFile(string filepath, EuroText_ProjectFile projObj)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter textWriter = XmlWriter.Create(filepath, settings);
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("ETXML");
                textWriter.WriteAttributeString("type", "PROJECTFILE");
                textWriter.WriteAttributeString("version", "1.0.0");
                textWriter.WriteStartElement("Info");
                if (string.IsNullOrEmpty(projObj.FirstCreated))
                {
                    textWriter.WriteElementString("FirstCreated", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                }
                else
                {
                    textWriter.WriteElementString("FirstCreated", projObj.FirstCreated);
                }
                if (string.IsNullOrEmpty(projObj.CreatedBy))
                {
                    textWriter.WriteElementString("CreatedBy", GlobalVariables.EuroTextUser);
                }
                else
                {
                    textWriter.WriteElementString("CreatedBy", projObj.CreatedBy);
                }
                textWriter.WriteElementString("LastModified", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                textWriter.WriteElementString("LastModifiedBy", GlobalVariables.EuroTextUser);
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("Properties");
                textWriter.WriteElementString("MessagesDirectory", projObj.MessagesDirectory);
                textWriter.WriteElementString("SpreadSheetsDirectory", projObj.SpreadSheetsDirectory);
                textWriter.WriteElementString("ELHashCodesServerPath", projObj.EuroLandHahCodesServPath);
                textWriter.WriteElementString("UnusedTextBit", projObj.UnusedTextBit.ToString());
                textWriter.WriteEndElement();

                // Languages section
                textWriter.WriteStartElement("Languages");
                foreach (string language in projObj.Languages)
                {
                    textWriter.WriteElementString("Language", language);
                }
                textWriter.WriteEndElement(); // </Languages>

                // Categories section
                textWriter.WriteStartElement("Categories");
                foreach (string category in projObj.Categories)
                {
                    textWriter.WriteElementString("Category", category);
                }
                textWriter.WriteEndElement(); // </Categories>

                // Tones section
                textWriter.WriteStartElement("Tones");
                foreach (string tone in projObj.Tones)
                {
                    textWriter.WriteElementString("Tone", tone);
                }
                textWriter.WriteEndElement(); // </Tones>

                // Genders section
                textWriter.WriteStartElement("Genders");
                foreach (string gender in projObj.Genders)
                {
                    textWriter.WriteElementString("Gender", gender);
                }
                textWriter.WriteEndElement(); // </Genders>

                // Contexts section
                textWriter.WriteStartElement("Contexts");
                foreach (string context in projObj.Contexts)
                {
                    textWriter.WriteElementString("Context", context);
                }
                textWriter.WriteEndElement(); // </Contexts>

                textWriter.WriteEndElement(); // </ETXML>
                textWriter.WriteEndDocument();
                textWriter.Close();
            }
            catch
            {

            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void WriteTextSections(string filepath, EuroText_TextSections projObj)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter textWriter = XmlWriter.Create(filepath, settings);
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("ETXML");
                textWriter.WriteAttributeString("type", "TEXTSECTIONSFILE");
                textWriter.WriteAttributeString("version", "1.0.0");
                textWriter.WriteStartElement("Info");
                if (string.IsNullOrEmpty(projObj.FirstCreated))
                {
                    textWriter.WriteElementString("FirstCreated", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                }
                else
                {
                    textWriter.WriteElementString("FirstCreated", projObj.FirstCreated);
                }
                if (string.IsNullOrEmpty(projObj.CreatedBy))
                {
                    textWriter.WriteElementString("CreatedBy", GlobalVariables.EuroTextUser);
                }
                else
                {
                    textWriter.WriteElementString("CreatedBy", projObj.CreatedBy);
                }
                textWriter.WriteElementString("LastModified", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                textWriter.WriteElementString("LastModifiedBy", GlobalVariables.EuroTextUser);
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("TextSections");
                foreach (KeyValuePair<string, string> textSection in projObj.TextSections)
                {
                    textWriter.WriteStartElement("TextSection");
                    textWriter.WriteAttributeString("sectionNumber", textSection.Key.ToString());
                    textWriter.WriteString(textSection.Value);
                    textWriter.WriteEndElement();
                }
                textWriter.WriteEndDocument();
                textWriter.Close();
            }
            catch
            {

            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void WriteTextGroups(string filepath, EuroText_TextGroups projObj)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true
                };
                XmlWriter textWriter = XmlWriter.Create(filepath, settings);
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("ETXML");
                textWriter.WriteAttributeString("type", "TEXTGROUPSFILE");
                textWriter.WriteAttributeString("version", "1.0.0");
                textWriter.WriteStartElement("Info");
                if (string.IsNullOrEmpty(projObj.FirstCreated))
                {
                    textWriter.WriteElementString("FirstCreated", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                }
                else
                {
                    textWriter.WriteElementString("FirstCreated", projObj.FirstCreated);
                }
                if (string.IsNullOrEmpty(projObj.CreatedBy))
                {
                    textWriter.WriteElementString("CreatedBy", GlobalVariables.EuroTextUser);
                }
                else
                {
                    textWriter.WriteElementString("CreatedBy", projObj.CreatedBy);
                }
                textWriter.WriteElementString("LastModified", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                textWriter.WriteElementString("LastModifiedBy", GlobalVariables.EuroTextUser);
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("TextGroups");
                foreach (string textSection in projObj.TextGroups)
                {
                    textWriter.WriteElementString("TextGroup", textSection);
                }
                textWriter.WriteEndDocument();
                textWriter.Close();
            }
            catch
            {

            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
