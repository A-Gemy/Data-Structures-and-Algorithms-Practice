using System;
using System.Collections.Generic;

namespace Find_Numbers_Disappeared_in_Array
{
    class Program
    {
        private static List<int> FindDisappearedNumbers(int[] numbers)
        {
            List<int> result = new List<int>();

            if (numbers == null || numbers.Length == 0)
                return result;

            HashSet<int> existingNumbers = new HashSet<int>(numbers);

            for (int i = 1; i <= numbers.Length; i++)
            {
                if (!existingNumbers.Contains(i))
                    result.Add(i);
            }

            return result; 
        }

        static void Main()
        {
            int[] numbers = { 4, 3, 2, 7, 8, 2, 3, 1 };

            Console.WriteLine("Numbers in array: " + string.Join(", ", numbers));
            Console.WriteLine("Missing numbers: " + string.Join(", ", FindDisappearedNumbers(numbers)));


            Console.ReadKey();
        }
    }
}
