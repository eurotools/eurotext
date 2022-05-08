using System;
using System.IO;

namespace EuroTextEditor
{
    internal class EXText_Reader
    {
        internal EXText ReadEXTextFile(string textFilePath)
        {
            EXText ObjText = new EXText();

            using (StreamReader sr = new StreamReader(File.Open(textFilePath, FileMode.Open)))
            {
                while (!sr.EndOfStream)
                {
                    string currentLine = sr.ReadLine().Trim();
                    if (string.IsNullOrEmpty(currentLine))
                    {
                        continue;
                    }

                    //Read parameters
                    if (currentLine.Equals("#Parameters"))
                    {
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            if (currentLine.StartsWith("MaxNumOfChars", StringComparison.OrdinalIgnoreCase))
                            {
                                ObjText.MaxNumOfChars = Convert.ToInt32(currentLine.Substring("MaxNumOfChars".Length).Trim());
                            }
                            if (currentLine.StartsWith("DeadText", StringComparison.OrdinalIgnoreCase))
                            {
                                ObjText.DeadText = Convert.ToInt32(currentLine.Substring("DeadText".Length).Trim());
                            }
                            if (currentLine.StartsWith("Group", StringComparison.OrdinalIgnoreCase))
                            {
                                ObjText.Group = currentLine.Substring("Group".Length).Trim();
                            }
                            if (currentLine.StartsWith("OutputSection", StringComparison.OrdinalIgnoreCase))
                            {
                                if (currentLine.Length > 13)
                                {
                                    ObjText.OutputSection = currentLine.Substring("OutputSection".Length).Trim();
                                }
                            }

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }

                    //Language
                    if (currentLine.Equals("#ENGLISH US", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[0] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#ENGLISH UK", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[1] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#GERMAN", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[2] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#FRENCH", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[3] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#SPANISH", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[4] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#ITALIAN", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[5] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#KOREAN", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[6] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                    if (currentLine.Equals("#JAPAN", StringComparison.OrdinalIgnoreCase))
                    {
                        //Read line
                        currentLine = sr.ReadLine().Trim();
                        while (!currentLine.Equals("#END", StringComparison.OrdinalIgnoreCase))
                        {
                            ObjText.TextLanguage[7] = currentLine;

                            //Read line
                            currentLine = sr.ReadLine().Trim();
                        }
                    }
                }
            }

            return ObjText;
        }
    }
}
