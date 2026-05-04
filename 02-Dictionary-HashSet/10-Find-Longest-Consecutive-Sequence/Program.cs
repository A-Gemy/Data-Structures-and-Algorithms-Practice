using System;
using System.Collections.Generic;

namespace Find_Longest_Consecutive_Sequence
{
    class Program
    {
        private static List<int> FindLongestConsecutiveSequence(int[] numbers)
        {
            List<int> sequence = new List<int>();

            if (numbers == null || numbers.Length == 0)
                return sequence;

            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            int longestLength = 0;
            int bestStart = 0;

            foreach (int number in uniqueNumbers)
            {
                // Check if it's the start of a sequence
                if (!uniqueNumbers.Contains(number - 1))
                {
                    int currentNumber = number;
                    int currentLength = 1;

                    while (uniqueNumbers.Contains(currentNumber + 1))
                    {
                        currentNumber++;
                        currentLength++;
                    }

                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        bestStart = number;
                    }
                }
            }

            for (int i = 0; i < longestLength; i++)
            {
                sequence.Add(bestStart + i);
            }

            return sequence;
        }

        static void Main()
        {
            int[] numbers = { 100, 4, 200, 1, 3, 2 };

            List<int> sequence = FindLongestConsecutiveSequence(numbers);

            Console.WriteLine($"Longest Sequence Length: {sequence.Count}");
            Console.WriteLine($"Sequence: {string.Join(", ", sequence)}");


            Console.ReadKey();
        }
    }
}
