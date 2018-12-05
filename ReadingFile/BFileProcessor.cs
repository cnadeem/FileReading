using System.Collections.Generic;

namespace ReadingFile
{
    public class BFileProcessor : IFileColumnDelimiter
    {
        private List<FileColumns> lstColumns;

        public BFileProcessor()
        {
            lstColumns = new List<FileColumns>
            {
                new FileColumns(){ Name = "NAME", startPosition = 0,endPosition = 29 },
                new FileColumns(){ Name = "ISBN", startPosition=30,endPosition=20 },
                new FileColumns(){ Name = "AUTHOR", startPosition=51, endPosition=10 }
            };
        }

        public List<FileColumns> GetFileColumnLength()
        {
            return lstColumns;
        }

    }
}
