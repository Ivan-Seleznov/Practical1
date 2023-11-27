using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical4
{
    public class TxtFileWriter:IWrite
    {
        public void WriteArray<T>(string path, IEnumerable<T> data)
        {
            string dataString = string.Join(Environment.NewLine, data);

            File.WriteAllText(path, dataString);
        }
    }
}
