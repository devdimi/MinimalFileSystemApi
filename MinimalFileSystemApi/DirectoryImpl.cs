using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalFileSystemApi
{
    public class MinimalDirectory : IDirectory
    {
        public IEnumerable<ILineReader> GetFiles(string pattern)
        {
            var files = Directory.EnumerateFiles("", "*.cs", SearchOption.AllDirectories);
            foreach (String file in  files)
            {
                var lineReader = new LineReader(file);
                yield return lineReader;
            }
        }
    }
}
