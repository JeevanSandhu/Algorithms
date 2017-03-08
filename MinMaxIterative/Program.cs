using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 6, 3, 7, 2, 8, 1, 9 };
            MinMax(array);
            Console.ReadKey();
        }

        public static void MinMax(int[] array)
        {
            int min = array[0], max = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
        }
    }
}