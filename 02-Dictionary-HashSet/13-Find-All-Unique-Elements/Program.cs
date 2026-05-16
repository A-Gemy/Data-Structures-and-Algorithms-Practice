using System;
using System.Collections.Generic;

namespace Find_All_Unique_Elements
{
    class Program
    {
        static List<int> FindUniqueElements(int[] numbers)
        {
            List<int> uniqueElements = new List<int>();

            if (numbers == null || numbers.Length == 0)
                return uniqueElements;

            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counts.ContainsKey(numbers[i]))
                    counts[numbers[i]] = 0;

                counts[numbers[i]]++;
            }

            foreach (KeyValuePair<int, int> pair in counts)
            {
                if (pair.Value == 1)
                    uniqueElements.Add(pair.Key);
            }

            return uniqueElements;
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 5, 3 };

            List<int> uniqueElements = FindUniqueElements(numbers);
            Console.WriteLine("Unique Elements: " + string.Join(", ", uniqueElements));


            Console.ReadKey();
        }

    }
}
