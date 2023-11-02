using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    public class CountMultiples
    {
        public CountMultiples(params int[] number)
        {
            numbers = number.ToList();
        }

        public int CountMultiplesOf27()
        {
            return numbers.Where(a => a % 27 == 0).Count();
        }

        List<int> numbers;
    }
}
