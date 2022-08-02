using System;

namespace MinimalFileSystemApi
{
    /// <summary>Minimal line writer interface.</summary>
    public interface ILineWriter : IDisposable
    {
        /// <summary> Write line of text to the writer.</summary><param name="line">the line of text</param>
        void WriteLine(String line);
    }
}
