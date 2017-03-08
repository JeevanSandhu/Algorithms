using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxRecursive
{
    class Program
    {
        static int[] array = { 5, 4, 6, 3, 7, 2, 8, 1, 9 };
        static void Main(string[] args)
        {
            int min = 0, max = 0;
            MinMax(0, array.Length - 1, ref min, ref max);
            Console.WriteLine("Min : " + min);
            Console.WriteLine("Max : " + max);
            Console.ReadKey();
        }

        public static void MinMax(int i, int j, ref int min, ref int max)
        {
            if (i == j)
            {
                min = max = array[i];
            }
            else if (i == j - 1)
            {
                if (array[i] < array[j])
                {
                    min = array[i];
                    max = array[j];
                }
                else
                {
                    max = array[i];
                    min = array[j];
                }
            }
            else
            {
                int mid = (i + j) / 2;
                int min1 = 0, max1 = 0, min2 = 0, max2 = 0;
                MinMax(i, mid, ref min1, ref max1);
                MinMax(mid + 1, j, ref min2, ref max2);
                if (max1 > max2)
                    max = max1;
                else max = max2;
                if (min1 < min2)
                    min = min1;
                else
                    min = min2;
            }
        }
    }
}