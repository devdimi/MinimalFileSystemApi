using System;
using System.Collections.Generic;
using System.Text;

namespace MinimalFileSystemApi
{
    /// <summary> Interface to read text line wise.</summary>
    public interface ILineReader : IDisposable
    {
        /// <summary>Read line of text, return null if no text is available.</summary>
        /// <returns>line of text.</returns>
        String ReadLine();

        /// <summary>Gets the file name. 
        /// NOTE filename might not be available if linereader is not based on file.
        /// In this case it should be empty string
        /// </summary>
        String FileName { get; }
    }
}
