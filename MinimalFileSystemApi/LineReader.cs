using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MinimalFileSystemApi
{
    /// <summary> Minimal Line Reader class.</summary>
    public class LineReader : ILineReader
    {
        private TextReader reader;

        /// <summary>Creates new instance of the MinimalLineReader class from the fileName.</summary>
        /// <param name="fileName">the file Name</param>
        public LineReader(String fileName) : this(new StreamReader(fileName)) 
        {
            this.FileName = fileName;
        }

        /// <summary>Creates new instance of the MinimalLineReader class from the TextReader.
        /// The text reader is disposed when this class is disposed.</summary>
        /// <param name="reader">the reader</param>
        public LineReader(TextReader reader) 
        {
            this.reader = reader; 
        }

        
        /// <inheritdoc />
        public String FileName { get; }

        public String ReadLine() 
        { 
            return this.reader.ReadLine(); 
        }

        public void Dispose() 
        { 
            this.reader.Dispose(); 
        }
    }
}
