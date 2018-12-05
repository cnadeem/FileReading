namespace ReadingFile
{
    public interface IReader
    {
        void Read(string path, IFileColumnDelimiter column);
    }
}
