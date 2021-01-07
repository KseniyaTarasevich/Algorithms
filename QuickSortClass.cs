using System;

namespace QuickSort
{
    class QuickSortClass
    {
        static void Main(string[] args)
        {
            int[] array = { 30, 10, 20, 10, 40, 0, 60 };
            QuickSort(array, 0, 6);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        private static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int leftBorder = leftIndex;
            int rightBorder = rightIndex;

            int pivot = array[leftIndex]; // support element

            while (leftIndex < rightIndex)
            {
                while (array[rightIndex] >= pivot && leftIndex < rightIndex)
                {
                    rightIndex--; // moves left while elements [rightIndex] >= pivot
                }

                if (leftIndex != rightIndex)
                {
                    array[leftIndex] = array[rightIndex];
                    leftIndex++;
                }

                while (array[leftIndex] <= pivot && leftIndex < rightIndex)
                {
                    leftIndex++; // moves right while elements [leftIndex] <= pivot
                }

                if (leftIndex != rightIndex)
                {
                    array[rightIndex] = array[leftIndex];
                    rightIndex--;
                }
            }

            array[leftIndex] = pivot;

            pivot = leftIndex;
            leftIndex = leftBorder;
            rightIndex = rightBorder;

            if (leftIndex < pivot)
            {
                QuickSort(array, leftIndex, pivot - 1);
            }

            if (rightIndex > pivot)
            {
                QuickSort(array, pivot + 1, rightIndex);
            }
        }
    }

}

