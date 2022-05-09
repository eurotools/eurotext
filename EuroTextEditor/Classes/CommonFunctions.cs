using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EuroTextEditor
{
    internal static class CommonFunctions
    {
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
    }
}
