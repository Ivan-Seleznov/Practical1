using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Array1DManager
    {
        public Array1DManager()
        {
            Random random = new Random();
            int n = random.Next(1,10);

            temps = new int[n];
            FillArrayRandom();
        }
        public Array1DManager(int[] tempsArray)
        {
            if (tempsArray.Length > 10)
            {
                throw new Exception("Temps size exception. Max size - 10. MinSize - 0");
            }

            temps = tempsArray;
        }
        public Array1DManager(int n)
        {
            if (n < 0 || n > 10)
            {
                throw new Exception("Temps size exception. Max size - 10. MinSize - 0");
            }

            temps = new int[n];
            FillArrayRandom();
        }

        public double CalculateAverageTemperature()
        {
            int sum = 0;
            foreach (int temperature in temps)
            {
                sum += temperature;
            }
            return (double)sum / temps.Length;
        }

        public int CountTemperaturesAboveAverage(double averageTemperature)
        {
            int count = 0;
            foreach (int temperature in temps)
            {
                if (temperature > averageTemperature)
                {
                    count++;
                }
            }
            return count;
        }

        void FillArrayRandom()
        {
            Random random = new Random();
            for (int i = 0; i < temps.Length; i++) 
            {
                temps[i] = random.Next(-5,5);
            }
        }

        public int Length { get { return temps.Length; }}
        public bool Error { get; protected set; }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < Length)
                {
                    return temps[i];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set 
            {
                if (i >= 0 && i < Length)
                {
                    temps[i] = value;
                }
                else
                {
                    Error = true;
                }
            }
        }

        private int[] temps;
    }
}
