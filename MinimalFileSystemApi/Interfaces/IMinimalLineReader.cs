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
    }
}
