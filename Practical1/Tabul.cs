using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    internal class Tabul
    {
        public double[,] xy { get; private set; }
        public int n { get; private set; }

        private double f1(double x)
        {
            return Math.Pow(x,4) + 2 * Math.Pow(x,3) - x;
        }
        private double f2(double x) 
        {
            return Math.Exp(-x) + Math.Pow(x, 0.25);
        }
        private double f3(double x) 
        {
            return Math.Log(Math.Pow(x, 3) + Math.Pow(x, 2));
        }

        public void Tab(double xn = -1.78, double xk = 11.99, double h = 0.1, double a = 0.8)
        {
            double x = xn;
            double y = 0;

            n = 0;

            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[n, 0] = x;
                xy[n, 1] = y;
                x = x + h;

                n++;
            }

        }
    }
}
