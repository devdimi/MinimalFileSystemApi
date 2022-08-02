using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinimalFileSystemApi
{
    /// <summary> This reader can be used for unit tests as it can be filled
    /// with lines without reading files.</summary>
    public class ReaderForTests : ILineReader
    {
        /// <summary>Gets the lines fed into the reader.</summary>
        public List<String> Lines { get; }

        /// <summary> Creates new instance of the ReaderForTests class.</summary>
        /// <param name="linesArg">the lines that the call will receive</param>
        public ReaderForTests(params String[] linesArg)
        {
            this.Lines = new List<string>(linesArg);
            this.enumerator = this.Lines.GetEnumerator();
        }

        /// <inheritdoc />
        public String FileName { get; set; }

        private IEnumerator enumerator;

        /// <inheritdoc />
        public void Dispose() { }

        /// <summary> Returns the lines passed in the constructor.</summary>
        /// <returns>the lines from the constructor</returns>
        public string ReadLine()
        {
            if (enumerator.MoveNext())
            {
                return enumerator.Current.ToString();
            }

            return null;
        }
    }
}
