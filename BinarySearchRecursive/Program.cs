using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchRecursive
{
    class Program
    {
        static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {
            int searchItem = 7;
            int x = binarySearch(0, array.Length - 1, searchItem);
            if (x == -1)
                Console.WriteLine("Item not found");
            else
                Console.WriteLine("Item found : " + array[x]);
            Console.ReadKey();
        }

        public static int binarySearch(int low, int high, int searchItem)
        {
            if(low == high)
            {
                if (searchItem == array[low])
                    return low;
                else return -1;
            }
            else
            {
                int mid = (low + high) / 2;
                if (searchItem == array[mid])
                    return mid;
                else if(searchItem < array[mid])
                {
                    return binarySearch(low, mid - 1, searchItem);
                }
                else
                {
                    return binarySearch(mid + 1, high, searchItem);
                }
            }
        }
    }
}
