using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int searchItem = 2;
            int x = binarySearch(array, searchItem);

            if (x == -1)
                Console.WriteLine("Item not found");
            else
                Console.WriteLine("Item found : " + array[x]);

            Console.ReadKey();
        }

        public static int binarySearch(int[] array, int searchItem)
        {
            int low = 0;
            int high = array.Length - 1;
            while(low<=high)
            {
                int mid = (low + high) / 2;
                if (searchItem == array[mid])
                    return mid;
                else if (searchItem > array[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}
