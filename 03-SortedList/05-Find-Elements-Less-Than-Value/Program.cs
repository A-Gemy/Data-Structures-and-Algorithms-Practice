using System;
using System.Collections.Generic;

namespace Find_Elements_Less_Than_Value
{
    class Program
    {
        private static SortedSet<int> FindElementsLessThanValue(SortedSet<int> set, int value)
        {
            if (set == null || set.Count == 0)
                return new SortedSet<int>();

            if (value <= set.Min)
                return new SortedSet<int>();

            SortedSet<int> result = new SortedSet<int>(set.GetViewBetween(set.Min, value - 1));

            return result;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            SortedSet<int> result = FindElementsLessThanValue(set, 4);

            Console.WriteLine("Original set: " + string.Join(", ", set));
            Console.WriteLine("Elements less than 4: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
