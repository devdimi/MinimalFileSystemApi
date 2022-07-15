using System;

namespace SimpleFileSystemAbstraction.Interfaces
{
    /// <summary> Interface that defines abstract file system.</summary>
    public interface IMinimalFileSystem
    {
        IMinimalLineReader GetReader(String fileName);
        IMinimalLineWriter GetWriter(String fileName);
        Boolean FileExists(String fileName);
        void FileDelete(String fileName);
    }
}
