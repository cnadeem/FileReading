using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ReadingFile;

namespace ReadingFileUnitTest
{
    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }

    [TestClass]
    public class UnitTesFile
    {
        static readonly string AFilePath = @"D:\NadeemProjects\ReadingFile\ReadingFile\A_Test.txt";
        static readonly string BFilePath = @"D:\NadeemProjects\ReadingFile\ReadingFile\B_Test.txt";
        [TestMethod]
        public void TestMethodFileA()
        {
            string output = "NAME : Charlie Bone Series  ISBN : 1234567890  AUTHOR : Jenny Nimm";
            var currentConsoleOut = Console.Out;

            IFileColumnDelimiter column = FileReaderUtility.DetermineFileType(AFilePath);
            IReader processor = new TextFileReader();
         
            using (var consoleOutput = new ConsoleOutput())
            {
                processor.Read(AFilePath, column);

                Assert.AreEqual(output,consoleOutput.GetOuput().Trim());
                Assert.AreNotEqual("[Error] : Invalid File Type", consoleOutput.GetOuput());

            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethodFileB()
        {
            string output = "NAME : A Fine and Private Place  ISBN : 4334445345564  AUTHOR : Peter";
            var currentConsoleOut = Console.Out;

            IFileColumnDelimiter column = FileReaderUtility.DetermineFileType(BFilePath);
            IReader processor = new TextFileReader();
       
            using (var consoleOutput = new ConsoleOutput())
            {
                processor.Read(BFilePath, column);

                Assert.AreEqual(output,consoleOutput.GetOuput().Trim());
                Assert.AreNotEqual("[Error] : Invalid File Type", consoleOutput.GetOuput());

            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
