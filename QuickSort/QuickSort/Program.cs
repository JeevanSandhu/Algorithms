using System;

namespace QuickSort
{
    class Program
    {
        //static int[] array = { 65, 70, 75, 80, 85, 60, 55, 50, 45 };
        static int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        static void Main(string[] args)
        {
            quickSort(0, array.Length);
            for (int k = 0; k < array.Length; ++k)
                Console.Write(array[k] + " ");
            Console.ReadKey();
        }

        public static void quickSort(int low, int high)
        {
            if (low < high)
            {
                int mid = partition(low, high);
                quickSort(low, mid);
                quickSort(mid + 1, high);
            }
        }

        public static int partition(int low, int high)
        {
            int pivot = array[low];
            int x = low;
            int i = low, j = high;
            do
            {
                do
                {
                    ++i;
                    if (i > array.Length - 1) break;
                } while (pivot > array[i]);
                do
                {
                    --j;
                    if (j < 0) break;
                } while (pivot < array[j]);
                if (i < j)
                    interchange(i, j);
            } while (i<j);
            array[x] = array[j];
            array[j] = pivot;
            return j;
        }

        public static void interchange(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
