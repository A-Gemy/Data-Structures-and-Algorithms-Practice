using System;
using System.Collections.Generic;

namespace Find_Elements_Not_in_the_Second_Array
{
    class Program
    {
        private static List<int> FindElementsNotInSecondArray(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            if (nums1 == null || nums1.Length == 0)
                return result;

            HashSet<int> nums2Set = nums2 == null
                ? new HashSet<int>()
                : new HashSet<int>(nums2);

            foreach (int num in nums1)
            {
                if (!nums2Set.Contains(num))
                    result.Add(num);
            }

            return result;
        }

        private static List<int> FindUniqueElementsNotInSecondArray(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0)
                return new List<int>();

            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = nums2 == null
                ? new HashSet<int>()
                : new HashSet<int>(nums2);

            set1.ExceptWith(set2);

            return new List<int>(set1);
        }

        static void Main()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 3, 4, 5, 6 };

            List<int> result = FindElementsNotInSecondArray(nums1, nums2);
            Console.WriteLine("Elements not in second array: " + string.Join(", ", result));

            List<int> resultWithSets = FindUniqueElementsNotInSecondArray(nums1, nums2);
            Console.WriteLine("Result with HashSet: " + string.Join(", ", resultWithSets));


            Console.ReadKey();
        }
    }
}
