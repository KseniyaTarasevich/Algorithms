using System;

namespace SelectionSort
{
    class SelectionSortClass
    {
        static void Main(string[] args)
        {
            int[] array = { 30, 10, 20, 10, 40, 0, 60 };
            SelectionSort(array);
        }

        private static void SelectionSort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallest = i; // smallest index = current index

                for (int j = i + 1; j < array.Length; j++) // compare with next element
                {
                    if (array[j] < array[smallest]) // if next element < previous
                    {
                        smallest = j; // change smallest index
                    }
                }

                if (smallest != i) // if smallest index is changed
                {                       // swap the elements
                    temp = array[i]; 
                    array[i] = array[smallest];
                    array[smallest] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}


