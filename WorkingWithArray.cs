using System;

namespace Array
{
    class WorkingWithArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int[] numbers1 = new int[5] { 0, 1, 2, 3, 4 };
            int[] numbers2 = new int[] { 0, 1, 2, 3, 4 };
            int[] numbers3 = { 0, 1, 2, 3, 4 };

            foreach (int i in numbers1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] *= 2;
                Console.Write(numbers2[i] + " ");
            }

            int[,] numbers4 = { { 0, 1, 2 }, { 3, 4, 5 } }; //two-dimensional array
            int[,] numbers5 = new int[5, 5];
            int[,] numbers6 = new int[2, 5] { { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 } };
            int[,] numbers7 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] numbers8 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] numbers9;

            int[,,] numbers10 = new int[5, 5, 5]; //three-dimensional array
            int[,,,] numbers11 = new int[5, 5, 5, 5]; //four-dimensional array

            Console.WriteLine();

            foreach (int i in numbers4)
            {
                Console.Write($"{i + " "}");
            }

            int rows = numbers6.GetUpperBound(0) + 1;
            int columns = numbers6.Length / rows;
            // int columns = numbers6.GetUpperBound(1) + 1;

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers6[i, j] + " "}");
                }
                Console.WriteLine();
            }

            int[][,] numbers13 = new int[3][,]
            {
                new int[,] {{0,1},{2,3}},
                new int[,] {{4,5},{6,7}},
                new int[,] {{8,9},{10,11}},
            };

            int[][] numbers12 = new int[3][]; // "зубчатый массив"
            numbers12[0] = new int[2] { 0, 1 };
            numbers12[1] = new int[3] { 0, 1, 2 };
            numbers12[2] = new int[5] { 0, 1, 2, 3, 4 };

            foreach (int[] row in numbers12)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number + " "}");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers12.Length; i++)
            {
                for (int j = 0; j < numbers12[i].Length; j++)
                {
                    Console.Write($"{numbers12[i][j] + " "}");
                }
                Console.WriteLine();
            }

            int[] num = { -3, -2, -1, 0, 1, 2, 3 };
            int temp;

            for (int i = 0; i < num.Length / 2; i++) // inversion
            {
                temp = num[i];
                num[i] = num[num.Length - i - 1];
                num[num.Length - i - 1] = temp;
            }

            foreach (int i in num)
            {
                Console.Write($"{i + " "}");
            }
        }
    }
}
