using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinimalFileSystemApi
{
    /// <summary>
    /// This reader can be used for unit tests as it can be filled
    /// with lines without reading files.
    /// </summary>
    public class ReaderForTests : ILineReader
    {
        /// <summary>Gets the lines fed into the reader.</summary>
        public List<String> Lines { get; }

        public ReaderForTests(params String[] linesArg)
        {
            this.Lines = new List<string>(linesArg);
            this.enumerator = this.Lines.GetEnumerator();
        }

        /// <inheritdoc />
        public String FileName { get; set; }

        private IEnumerator enumerator;

        public void Dispose() { }

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
