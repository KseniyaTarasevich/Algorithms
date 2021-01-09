using System;

namespace BubbleSort
{
    class BubbleSortClass
    {
        static void Main(string[] args)
        {
            int[] array = { 30, 10, 20, 10, 40, 0, 60 };
            BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

        }

        private static int[] BubbleSort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }
            return array;
        }
    }
}