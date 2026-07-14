using System;
using System.Collections.Generic;

namespace Find_All_Elements_Not_in_Range
{
    class Program
    {
        private static SortedSet<int> ElementsNotInRange(SortedSet<int> set, int low, int high)
        {
            if (set == null || set.Count == 0)
                return new SortedSet<int>();

            if (low > high)
            {
                return new SortedSet<int>(set);
            }

            SortedSet<int> result = new SortedSet<int>(set);
            result.GetViewBetween(low, high).Clear();

            return result;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original set: " + string.Join(", ", set));

            var result = ElementsNotInRange(set, 2, 4);

            Console.WriteLine("Elements not in range [2, 4]: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
