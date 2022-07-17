using MinimalFileSystemApi.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinimalFileSystemApi
{
    public class ReaderForTests : ILineReader
    {
        public List<String> Lines;

        public ReaderForTests(params String[] linesArg)
        {
            this.Lines = new List<string>(linesArg);
            this.enumerator = this.Lines.GetEnumerator();
        }

        private IEnumerator enumerator;

        public void Dispose() { }

        public string ReadLine()
        {
            if (enumerator.MoveNext())
            {
                return enumerator.Current.ToString();
            }

            return null;
        }
    }
}
