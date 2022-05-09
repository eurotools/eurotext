using System.IO;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class EXText_Writer
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void EXTextObjectToTextFile(EXText objectText, string outputFilePath)
        {
            using (StreamWriter writetext = new StreamWriter(outputFilePath))
            {
                writetext.WriteLine("#Parameters");
                writetext.Write(string.Join(" ", "MaxNumOfChars", objectText.MaxNumOfChars));
                writetext.Write(string.Join(" ", "DeadText", objectText.DeadText));
                writetext.Write(string.Join(" ", "Group", objectText.Group));
                writetext.Write(string.Join(" ", "OutputSection", objectText.OutputSection));
                writetext.WriteLine("#END");
                if (objectText.TextLanguage[0].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#English US");
                    writetext.WriteLine(objectText.TextLanguage[0]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[1].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#English UK");
                    writetext.WriteLine(objectText.TextLanguage[1]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[2].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#German");
                    writetext.WriteLine(objectText.TextLanguage[2]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[3].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#French");
                    writetext.WriteLine(objectText.TextLanguage[3]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[4].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#Spanish");
                    writetext.WriteLine(objectText.TextLanguage[4]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[5].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#Italian");
                    writetext.WriteLine(objectText.TextLanguage[5]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[6].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#Korean");
                    writetext.WriteLine(objectText.TextLanguage[6]);
                    writetext.WriteLine("#END");
                }
                if (objectText.TextLanguage[7].Length > 0)
                {
                    writetext.WriteLine("");
                    writetext.WriteLine("#JAPAN");
                    writetext.WriteLine(objectText.TextLanguage[7]);
                    writetext.WriteLine("#END");
                }
            }
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
