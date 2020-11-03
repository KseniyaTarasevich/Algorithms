namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            BinarySearch(numbers, 3); // Checking function with existing value
            BinarySearch(numbers, -1); // Checking function with incorrect value
        }

        
        static int? BinarySearch(int[] array, int searchedValue)
        {
            // First, middle and last indexes of the array, guessed value
            int firstIndex = 0;
            int lastIndex = array.Length - 1;
            int middleIndex;
            int guessedValue;

            while (firstIndex <= lastIndex)
            {
                middleIndex = (firstIndex + lastIndex) / 2;
                guessedValue = array[middleIndex];

                if (guessedValue == searchedValue) // If guessedValue is equal to searchedValue - the Value is finded
                {
                    return middleIndex;
                }

                else if (guessedValue > searchedValue) // If guessedValue > searchedValue - continue searching in left direction
                {
                    lastIndex = middleIndex - 1;
                }

                else // Else - continue searching in right direction
                {
                    firstIndex = middleIndex + 1;
                }

            }
            return null; // Searched value was not found
        }
    }
}
