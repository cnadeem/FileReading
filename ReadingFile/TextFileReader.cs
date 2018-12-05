using System.Collections.Generic;

namespace ReadingFile
{
    public class TextFileReader : IReader
    {
        private List<FileColumns> lstColumns;

        public void Read(string path, IFileColumnDelimiter columns)
        {
            lstColumns = columns.GetFileColumnLength();
            FileReaderUtility.ReadAndWriteFileConent(path, lstColumns);
        }
    }
}
