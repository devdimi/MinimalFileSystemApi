using System;
using System.IO;

namespace SimpleFileSystemAbstraction
{
    /// <summary>This class creates temporary file when created which is deleted when disposed.</summary>
    public class TemporayFile : IDisposable
    {
        /// <summary>Create new instance of the TemporaryFile class.</summary>
        public TemporayFile()
        {
            this.FileName = Path.GetTempFileName();
        }

        /// <summary>Gets the File name</summary>
        public String FileName { get; }

        public void Dispose()
        {
            if (File.Exists(this.FileName))
            {
                File.Delete(FileName);
            }
        }
    }
}
