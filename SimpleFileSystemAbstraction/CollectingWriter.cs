using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
namespace SimpleFileSystemAbstraction
{
    public class CollectingWriter : IMinimalLineWriter
    {
        public void Dispose()
        { }

        public List<String> Lines = new List<String>();
        public void WriteLine(string line)
        {
            Lines.Add(line);
        }
    }
}
