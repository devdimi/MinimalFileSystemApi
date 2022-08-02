using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalFileSystemApi
{
    /// <summary> Minimal real file system implementation.</summary>
    public class MinimalFileSystem : IMinimalFileSystem
    {
        /// <inheritdoc />
        public void FileDelete(string fileName)
        {
           File.Delete(fileName);
        }

        /// <inheritdoc />
        public bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        /// <inheritdoc />
        public ILineReader GetReader(string fileName)
        {
            return new LineReader(new StreamReader(fileName));
        }

        /// <inheritdoc />
        public ILineWriter GetWriter(string fileName)
        {
            return new LineWriter(new StreamWriter(fileName));
        }
    }
}
