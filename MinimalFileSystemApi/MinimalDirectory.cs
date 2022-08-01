using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalFileSystemApi
{
    /// <summary> Minimal directory implementation.</summary>
    public class MinimalDirectory : IDirectory
    {
        /// <summary>Get the files in this directory and all subdirectories.</summary>
        /// <param name="dir">the directory</param> <param name="pattern">the pattern</param>
        /// <returns>IEnumerable of line readers.</returns>
        public IEnumerable<ILineReader> GetFiles(String dir, string pattern)
        {
            var files = Directory.EnumerateFiles(dir, pattern, SearchOption.AllDirectories);
            foreach (String file in  files)
            {
                var lineReader = new LineReader(file);
                yield return lineReader;
            }
        }
    }
}
