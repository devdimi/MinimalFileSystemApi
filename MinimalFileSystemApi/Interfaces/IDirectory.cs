using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalFileSystemApi
{
    /// <summary>
    /// Interface to read files from directory
    /// </summary>
    public interface IDirectory
    {
        /// <summary>
        /// Get all files 
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        IEnumerable<ILineReader> GetFiles(String pattern);
    }
}
