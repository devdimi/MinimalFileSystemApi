using System;
using System.Collections.Generic;
namespace MinimalFileSystemApi
{
    public class CollectingWriter : ILineWriter
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
