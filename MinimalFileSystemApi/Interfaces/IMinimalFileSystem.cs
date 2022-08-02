using System;

namespace MinimalFileSystemApi
{
    /// <summary> Interface that defines abstract file system.</summary>
    public interface IMinimalFileSystem
    {
        /// <summary>Gets a line reader for the given file name.</summary>
        /// <param name="fileName">the file name</param><returns>line reader instance</returns>
        ILineReader GetReader(String fileName);
        
        /// <summary>Get writer for the given filename</summary>
        /// <param name="fileName">the file name</param><returns>file writer instance</returns>
        ILineWriter GetWriter(String fileName);
        
        /// <summary>Check if a file exists.</summary><param name="fileName">the file name</param><returns>true if the file exists.</returns>
        Boolean FileExists(String fileName);
        
        /// <summary>Delete the file.</summary><param name="fileName">file to delete</param>
        void FileDelete(String fileName);
    }
}
