using System;
using System.Collections.Generic;
namespace MinimalFileSystemApi
{
    /// <summary> Writer that collects what is written to it</summary>
    public class CollectingWriter : ILineWriter
    {
        /// <inheritdoc />
        public void Dispose()
        { }

        /// <summary>Gets the lines that are written to the writer.</summary>
        public List<String> Lines = new List<String>();
        
        /// <inheritdoc />
        public void WriteLine(string line)
        {
            Lines.Add(line);
        }
    }
}
