using System;

namespace MinimalFileSystemApi.Interfaces
{
    /// <summary> Interface that defines abstract file system.</summary>
    public interface IMinimalFileSystem
    {
        ILineReader GetReader(String fileName);
        ILineWriter GetWriter(String fileName);
        Boolean FileExists(String fileName);
        void FileDelete(String fileName);
    }
}
