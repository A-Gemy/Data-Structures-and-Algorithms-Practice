using System;
using System.Collections.Generic;

namespace Sort_And_Remove_Duplicates
{
    class Program
    {
        private static SortedSet<int> SortAndRemoveDuplicates(List<int> numbers)
        {
            return new SortedSet<int>(numbers);
        }

        static void Main()
        {
            List<int> numbers = new List<int>
            {
                5, 2, 8, 2, 1, 5, 3, 8, 4
            };

            SortedSet<int> sortedSet = SortAndRemoveDuplicates(numbers);

            foreach (var item in sortedSet)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
