using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical4
{
    public class CustomIntArray : IEnumerable<int>
    {
        private List<int> items;

        public CustomIntArray(List<int> arr)
        {
            items = arr;
        }
        public CustomIntArray()
        {
            items = new List<int>();
        }
        public void Add(int item)
        {
            items.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void MoveSecondNonZeroElementToFront()
        {
            int nonZeroCount = 0;
            int secondNonZeroIndex = -1;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] != 0)
                {
                    nonZeroCount++;
                    if (nonZeroCount == 2)
                    {
                        secondNonZeroIndex = i;
                        break;
                    }
                }
            }

            if (secondNonZeroIndex != -1)
            {
                int temp = items[secondNonZeroIndex];
                for (int i = secondNonZeroIndex; i > 0; i--)
                {
                    items[i] = items[i - 1];
                }
                items[0] = temp;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", items.Select(x => x.ToString()));
        }
    }
}
