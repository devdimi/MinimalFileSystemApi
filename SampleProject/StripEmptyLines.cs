using MinimalFileSystemApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class StripEmptyLines
    { 
        public void Process(ILineReader reader, ILineWriter writer)
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
