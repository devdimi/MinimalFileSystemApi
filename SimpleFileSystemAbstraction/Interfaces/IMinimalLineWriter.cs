using System;

namespace SimpleFileSystemAbstraction.Interfaces
{
    /// <summary>Minimal line writer interface.</summary>
    public interface IMinimalLineWriter : IDisposable
    {
        void WriteLine(String line);
    }

}
