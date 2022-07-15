using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileSystemAbstraction
{
    public class MinimalLineWriter : IMinimalLineWriter
    {
        private System.IO.TextWriter writer;

        public MinimalLineWriter(TextWriter writer) { this.writer = writer; }
        public void WriteLine(String line) { this.writer.WriteLine(line); }
        public void Dispose() { this.writer.Dispose(); }
    }
}
