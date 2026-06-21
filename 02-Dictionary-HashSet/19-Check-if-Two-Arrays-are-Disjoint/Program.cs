using System;
using System.Collections.Generic;

namespace Check_if_Two_Arrays_are_Disjoint
{
    class Program
    {
        private static bool AreArraysDisjoint(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0)
                return true;

            int[] smallerArray = nums1.Length <= nums2.Length ? nums1 : nums2;
            int[] largerArray = nums1.Length <= nums2.Length ? nums2 : nums1;

            HashSet<int> numbersSet = new HashSet<int>(smallerArray);

            foreach (int num in largerArray)
            {
                if (numbersSet.Contains(num))
                    return false;
            }

            return true;
        }

        static void Main()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };

            if (AreArraysDisjoint(nums1, nums2))
                Console.WriteLine("Arrays are disjoint.");
            else
                Console.WriteLine("Arrays are not disjoint.");


            Console.ReadKey();
        }
    }
}
