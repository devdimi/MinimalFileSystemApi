using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalFileSystemApi
{
    public class MinimalFileSystem : IMinimalFileSystem
    {
        public void FileDelete(string fileName)
        {
           File.Delete(fileName);
        }

        public bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public ILineReader GetReader(string fileName)
        {
            return new LineReader(new StreamReader(fileName));
        }

        public ILineWriter GetWriter(string fileName)
        {
            return new LineWriter(new StreamWriter(fileName));
        }
    }
}
