using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileSystemAbstraction
{
    /// <summary> Minimal Line Reader class.</summary>
    public class MinimalLineReader : IMinimalLineReader
    {
        private TextReader reader;

        /// <summary>Creates new instance of the MinimalLineReader class from the fileName.</summary>
        /// <param name="fileName">the file Name</param>
        public MinimalLineReader(String fileName) : this(new StreamReader(fileName)) 
        { 
        }

        /// <summary>Creates new instance of the MinimalLineReader class from the TextReader.
        /// The text reader is disposed when this class is disposed.</summary>
        /// <param name="reader">the reader</param>
        public MinimalLineReader(TextReader reader) 
        {
            this.reader = reader; 
        }

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
