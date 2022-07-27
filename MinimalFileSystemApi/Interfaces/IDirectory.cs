using System;
using System.Collections.Generic;

namespace MinimalFileSystemApi
{
    /// <summary>Interface to read files from directory</summary>
    public interface IDirectory
    {
        /// <summary>Get all files matching the pattern
        /// in the directory and all sub directories.
        /// </summary><param name="dir">the directory</param> 
        /// <param name="pattern">the file pattern</param>
        /// <returns>IEnumerbale of files.</returns>
        IEnumerable<ILineReader> GetFiles(String dir, String pattern);
    }
}
