using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical4
{
    public interface IWrite
    {
        void WriteArray<T>(string path, IEnumerable<T> data);
    }
}
