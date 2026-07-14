using System;
using System.Collections.Generic;

namespace Count_of_Elements_Less_Than_or_Equal_to_Value
{
    class Program
    {
        private static int CountElementsLessThanOrEqualToValue(SortedSet<int> set, int value)
        {
            if (set == null || set.Count == 0)
                return 0;

            if (value < set.Min)
                return 0;

            if (value >= set.Max)
                return set.Count;

            return set.GetViewBetween(set.Min, value).Count;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            int count = CountElementsLessThanOrEqualToValue(set, 3);

            Console.WriteLine("Original set: " + string.Join(", ", set));
            Console.WriteLine("Number of elements less than or equal to 3: " + count);

            Console.ReadKey();
        }
    }
}
