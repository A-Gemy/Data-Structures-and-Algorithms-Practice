using System;
using System.Collections.Generic;

namespace Remove_All_Elements_Within_Range
{
    class Program
    {
        private static void RemoveElementsWithinRange(SortedSet<int> set, int low, int high)
        {
            if (set == null || set.Count == 0)
                return;

            if (low > high)
            {
                Console.WriteLine("Low value cannot be greater than high value.");
                return;
            }

            set.GetViewBetween(low, high).Clear();
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original set: " + string.Join(", ", set));

            RemoveElementsWithinRange(set, 2, 4);

            Console.WriteLine("After removal: " + string.Join(", ", set));


            Console.ReadKey();
        }
    }
}
