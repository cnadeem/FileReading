using System.Collections.Generic;

namespace ReadingFile
{
    public class AFileProcessor : IFileColumnDelimiter
    {
        private List<FileColumns> lstColumns;
        public AFileProcessor()
        {
            lstColumns = new List<FileColumns>
            {
                new FileColumns(){ Name = "NAME", startPosition = 0,endPosition = 19 },
                new FileColumns(){ Name = "ISBN", startPosition=20,endPosition=20 },
                new FileColumns(){ Name = "AUTHOR", startPosition=41, endPosition=10 }
            };
        }

        public List<FileColumns> GetFileColumnLength()
        {
            return lstColumns;
        }
    }
}
