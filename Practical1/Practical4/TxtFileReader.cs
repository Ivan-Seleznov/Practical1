using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical4
{
    public class TxtFileReader : IRead
    {
        public IEnumerable<T> ReadArray<T>(string path)
        {

            string dataString = File.ReadAllText(path);

            string[] lines = dataString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            T[] data = new T[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = (T)Convert.ChangeType(lines[i], typeof(T));
            }

            return data;
        }
    }
}
