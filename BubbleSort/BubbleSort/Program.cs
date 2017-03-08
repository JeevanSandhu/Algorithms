using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 4, 1, 3};

            for (int i=0; i < array.Length; ++i)
            {
                for(int j=0; j<array.Length-1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for(int i=0;i<array.Length;++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
