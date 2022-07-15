using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileSystemAbstraction
{
    public class MinimalLineReader : IMinimalLineReader
    {
        private TextReader reader;

        public MinimalLineReader(TextReader reader) { this.reader = reader; }
        public String ReadLine() { return this.reader.ReadLine(); }
        public void Dispose() { this.reader.Dispose(); }
    }
}
