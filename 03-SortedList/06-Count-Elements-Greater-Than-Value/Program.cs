using System;
using System.Collections.Generic;

namespace Count_Elements_Greater_Than_Value
{
    class Program
    {
        private static int CountElementsGreaterThanValue(SortedSet<int> set, int value)
        {
            if (set == null || set.Count == 0)
                return 0;

            if (value < set.Min)
                return set.Count;

            if (value >= set.Max)
                return 0;

            return set.GetViewBetween(value + 1, set.Max).Count;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            int count = CountElementsGreaterThanValue(set, 3);

            Console.WriteLine("Original set: " + string.Join(", ", set));
            Console.WriteLine("Number of elements greater than 3: " + count);

            Console.ReadKey();
        }
    }
}
