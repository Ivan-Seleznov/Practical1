using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    public class CalculationAB
    {
        public CalculationAB(int a, int b)
        {
            A = a; B = b;
        }

        public int CountNumbers()
        {
            int count = 0;

            for (int i = A; i <= B; i++)
            {
                if (i % 17 == 0 && i % 2 == 0 && i % 7 == 3)
                {
                    count++;
                }
            }

            return count;
        }

        public int A { get; set; }
        public int B { get; set; }
    }
}
