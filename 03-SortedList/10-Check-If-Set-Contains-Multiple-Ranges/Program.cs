using System;
using System.Collections.Generic;

namespace Check_If_Set_Contains_Multiple_Ranges
{
    class Program
    {
        private static bool ContainsMultipleRanges(SortedSet<int> set, List<(int low, int high)> ranges)
        {
            if (set == null || set.Count == 0 || ranges == null || ranges.Count == 0)
                return false;

            foreach (var range in ranges)
            {
                if (range.low > range.high)
                    return false;

                var view = set.GetViewBetween(range.low, range.high);

                int expectedCount = range.high - range.low + 1;

                // Check if the view contains all elements in the range
                if (view.Count != expectedCount)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            List<(int low, int high)> ranges = new List<(int low, int high)>
            {
                (1, 2),
                (4, 5)
            };

            bool result = ContainsMultipleRanges(set, ranges);

            Console.WriteLine("Set: " + string.Join(", ", set));
            Console.WriteLine("Contains all ranges: " + result);


            Console.ReadKey();
        }
    }
}
