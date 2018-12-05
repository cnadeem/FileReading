using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFile
{
    class MainClass
    {
        static readonly string AFilePath = @"D:\NadeemProjects\ReadingFile\ReadingFile\A.txt";
        static readonly string BFilePath = @"D:\NadeemProjects\ReadingFile\ReadingFile\B.txt";

        static void Main(string[] args)
        {
            Console.WriteLine(" ************* START PROCESSING A File ******************");
            Console.WriteLine();

            IFileColumnDelimiter column = FileReaderUtility.DetermineFileType(AFilePath);
            IReader processor = new TextFileReader();
            processor.Read(AFilePath, column);

            Console.WriteLine();
            Console.WriteLine(" ************* START PROCESSING B File ******************");
            Console.WriteLine();

            column = FileReaderUtility.DetermineFileType(BFilePath);
            processor = new TextFileReader();
            processor.Read(BFilePath, column);
        }
    }
}
