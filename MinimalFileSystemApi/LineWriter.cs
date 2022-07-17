using MinimalFileSystemApi.Interfaces;
using System;
using System.IO;

namespace MinimalFileSystemApi
{
    /// <summary>Class to write </summary>
    public class LineWriter : ILineWriter
    {
        /// <summary>internal writer.</summary>
        private System.IO.TextWriter writer;

        /// <summary>Creates new instance of the MinimalLineWriter based on the file name.</summary>
        /// <param name="fileName">the file name</param>
        public LineWriter(String fileName) : this(new StreamWriter(fileName))
        {
        }

        /// <summary>
        /// Creates new instance of the class with the textwriter. When instance of the class is disposed this writer is also disposed.</summary>
        /// <param name="writer">the writer</param>
        public LineWriter(TextWriter writer) 
        {
            this.writer = writer; 
        }

        /// <summary>Write line to the writer.</summary><param name="line">the line to write</param>
        public void WriteLine(String line) 
        { 
            this.writer.WriteLine(line); 
        }

        /// <summary>Dispose the instance and the used internal writer.</summary>
        public void Dispose() 
        { 
            this.writer.Dispose();
        }
    }
}
