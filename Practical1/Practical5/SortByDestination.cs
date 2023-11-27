using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical5
{
    public class SortByDestination : IComparer<Flight>
    {
        public int Compare(Flight x, Flight y)
        {
            return string.Compare(x.Destination, y.Destination, StringComparison.Ordinal);
        }
    }
}
