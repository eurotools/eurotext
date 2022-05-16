using System;
using System.Collections.Generic;
using System.Xml;

namespace EuroTextEditor
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
                textWriter.WriteStartElement("Properties");
                textWriter.WriteElementString("Group", textObj.Group);
                textWriter.WriteElementString("OutputSection", textObj.OutputSection);
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
                textWriter.WriteElementString("MessagesDirectory", GlobalVariables.CurrentProject.MessagesDirectory);
                textWriter.WriteElementString("SpreadSheetsDirectory", GlobalVariables.CurrentProject.SpreadSheetsDirectory);
                textWriter.WriteElementString("ELHashCodesServerPath", GlobalVariables.CurrentProject.EuroLandHahCodesServPath);
                textWriter.WriteEndElement();
                textWriter.WriteStartElement("Languages");
                foreach (string language in projObj.Languages)
                {
                    textWriter.WriteElementString("Language", language);
                }
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
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
