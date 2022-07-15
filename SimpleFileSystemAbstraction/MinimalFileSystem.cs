using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileSystemAbstraction
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

        public IMinimalLineReader GetReader(string fileName)
        {
            return new MinimalLineReader(new StreamReader(fileName));
        }

        public IMinimalLineWriter GetWriter(string fileName)
        {
            return new MinimalLineWriter(new StreamWriter(fileName));
        }
    }
}
