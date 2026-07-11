using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Elements_in_Range
{
    class Program
    {
        private static List<int> FindElementsInRange(SortedSet<int> set, int low, int high)
        {
            if (set == null || set.Count == 0)
                return new List<int>();

            List<int> result = set.GetViewBetween(low, high).ToList();

            return result;
        }

        static void Main()
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            List<int> result = FindElementsInRange(set, 2, 4);

            Console.WriteLine("Numbers in set: " + string.Join(", ", set));
            Console.WriteLine("Elements in range: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
