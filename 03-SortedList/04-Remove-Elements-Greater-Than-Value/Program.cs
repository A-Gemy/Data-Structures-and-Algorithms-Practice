using System;
using System.Collections.Generic;

namespace Remove_Elements_Greater_Than_Value
{
    class Program
    {
        private static SortedSet<int> RemoveElementsGreaterThanValue(SortedSet<int> set, int value)
        {
            if (set == null || set.Count == 0)
                return new SortedSet<int>();

            if (value < set.Min)
                return new SortedSet<int>();

            SortedSet<int> result = new SortedSet<int>(set.GetViewBetween(set.Min, value));

            return result;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            SortedSet<int> result = RemoveElementsGreaterThanValue(set, 3);

            Console.WriteLine("Original set: " + string.Join(", ", set));
            Console.WriteLine("Elements less than or equal to 3: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
