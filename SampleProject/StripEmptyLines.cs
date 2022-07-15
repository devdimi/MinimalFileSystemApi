using SimpleFileSystemAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class StripEmptyLines
    { 
        public void Process(IMinimalLineReader reader, IMinimalLineWriter writer)
        {
            String line = null;
            while (null != (line = reader.ReadLine()))
            {
                if (!String.IsNullOrEmpty(line))
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
