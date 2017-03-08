using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortRecursive
{
    class Program
    {
        static int[] array = { 5, 4, 6, 3, 7, 2, 8, 1, 9 };
        static int[] temp = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static void Main(string[] args)
        {
            MergeSort(0, array.Length - 1);
            for (int i = 0; i < array.Length; ++i)
                Console.Write(array[i] + " ");
            Console.ReadKey();
        }

        public static void MergeSort(int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(low, mid);
                MergeSort(mid + 1, high);
                Merge(low, mid, high);
            }
        }

        public static void Merge(int low, int mid, int high)
        {
            int i = low, j = mid + 1, k = low;
            while ((i<=mid) && (j<=high))
            {
                if(array[i] < array[j])
                {
                    temp[k] = array[i];
                    ++i;
                }
                else
                {
                    temp[k] = array[j];
                    ++j;
                }
                ++k;
            }
            if (i > mid)
            {
                for (int l = j; l <= high; ++l)
                {
                    temp[k] = array[l];
                    ++k;
                }
            }
            else
            {
                for (int l = i; l <= mid; ++l)
                {
                    temp[k] = array[l];
                    ++k;
                }
            }

            for (int l = low; l <= high; ++l)
            {
                array[l] = temp[l];
            }
        }
    }
}
