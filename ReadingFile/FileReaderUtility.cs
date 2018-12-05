using System;
using System.Collections.Generic;
using System.IO;

namespace ReadingFile
{
    public static class FileReaderUtility
    {
        public static void ReadAndWriteFileConent(string path, List<FileColumns> lstColumns)
        {
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var TabLength = 4;
                    var TabSpace = new String(' ', TabLength);

                    line = line.Replace("\t", TabSpace);

                    if (line.Length > 1)
                    {
                        foreach (FileColumns column in lstColumns)
                        {
                            Console.Write(string.Format(" {0} : {1} ", column.Name, line.Substring(column.startPosition, column.endPosition).Trim()));
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        public static IFileColumnDelimiter DetermineFileType(string path)
        {
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine("[Error] : Invalid File Type");
                    }
                    else
                    {
                        switch (line.ToUpper())
                        {
                            case "A":
                                return new AFileProcessor();
                            case "B":
                                return new BFileProcessor();
                        }
                    }
                }
                return null;
            }
        }
    }
}
