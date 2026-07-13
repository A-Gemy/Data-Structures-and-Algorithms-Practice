using System;
using System.Collections.Generic;

namespace Union_of_Two_SortedSets
{
    class Program
    {
        private static SortedSet<int> UnionOfTwoSortedSets(SortedSet<int> set1, SortedSet<int> set2)
        {
            if (set1 == null && set2 == null)
                return new SortedSet<int>();

            if (set1 == null)
                return new SortedSet<int>(set2);

            if (set2 == null)
                return new SortedSet<int>(set1);

            SortedSet<int> unionSet = new SortedSet<int>(set1);
            unionSet.UnionWith(set2);

            return unionSet;
        }

        static void Main()
        {
            SortedSet<int> nums1 = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> nums2 = new SortedSet<int> { 3, 4, 5 };

            SortedSet<int> result = UnionOfTwoSortedSets(nums1, nums2);
            Console.WriteLine("Union of the two sorted sets: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
