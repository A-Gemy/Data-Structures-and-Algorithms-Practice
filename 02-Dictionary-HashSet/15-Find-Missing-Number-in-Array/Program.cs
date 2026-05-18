using System;
using System.Collections.Generic;

namespace Find_Missing_Number_in_Array
{
    class Program
    {
        private static int FindMissingNumber(int[] numbers)
        {
            if (numbers == null)
                return -1;

            Dictionary<int, bool> numberMap = new Dictionary<int, bool>();

            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                if (!numberMap.ContainsKey(numbers[i]))
                    numberMap[numbers[i]] = true;
            }

            for (int i = 0; i <= n; i++)
            {
                if (!numberMap.ContainsKey(i))
                    return i;
            }

            return -1; // No missing number found
        }

        private static int FindMissingNumberUsingHashSet(int[] numbers)
        {
            if (numbers == null)
                return -1;

            HashSet<int> numberSet = new HashSet<int>(numbers);

            int n = numbers.Length;
            for (int i = 0; i <= n; i++)
            {
                if (!numberSet.Contains(i))
                    return i;
            }

            return -1; // No missing number found
        }

        static void Main()
        {
            int[] numbers = { 3, 0, 1 };

            Console.WriteLine("Numbers in array: " + string.Join(", ", numbers));
            Console.WriteLine("Missing number: " + FindMissingNumber(numbers));
            Console.WriteLine("Missing number using HashSet: " + FindMissingNumberUsingHashSet(numbers));


            Console.ReadKey();
        }
    }
}
