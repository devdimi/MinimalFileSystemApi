using System;

namespace MinimalFileSystemApi.Interfaces
{
    /// <summary>Minimal line writer interface.</summary>
    public interface ILineWriter : IDisposable
    {
        void WriteLine(String line);
    }
}
