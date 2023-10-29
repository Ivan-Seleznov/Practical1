using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Array2DManager
    {
        public Array2DManager()
        {
            Random random = new Random();
            int rows = random.Next(1, 5);
            int cols = random.Next(1, 5);

            array2d = new int[rows,cols];
            FillArrayRandom();
        }
        public Array2DManager(int[,] newArray2D)
        {
            if (newArray2D.GetLength(0) < 0 || newArray2D.GetLength(0) > 5 || newArray2D.GetLength(1) < 0 || newArray2D.GetLength(1) > 5)
            {
                throw new Exception("Temps size exception. Max size - 10. MinSize - 0");
            }

            array2d = newArray2D;
        }
        public Array2DManager(int rows,int cols)
        {
            if (rows < 0 || rows > 5 || cols < 0 || cols > 5)
            {
                throw new Exception("Temps size exception. Max size - 10. MinSize - 0");
            }

            array2d = new int[rows, cols];
            FillArrayRandom();
        }

        void FillArrayRandom()
        {
            Random random = new Random();
            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColsCount; j++)
                {
                    array2d[i, j] = random.Next(-10,10);
                }
            }
        }

        public int CountNegativeBelowDiagonal()
        {
            int count = 0;

            for (int i = 1; i < RowsCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array2d[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public int RowsCount { get { return array2d.GetLength(0); } }
        public int ColsCount { get { return array2d.GetLength(1); } }
        public bool Error { get; protected set; }
        public int this[int i,int j]
        {
            get
            {
                if (i >= 0 && i < RowsCount && j >= 0 && i < ColsCount)
                {
                    return array2d[i,j];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < RowsCount && j >= 0 && i < ColsCount)
                {
                    array2d[i,j] = value;
                }
                else
                {
                    Error = true;
                }
            }
        }

        private int[,] array2d;
    }
}
