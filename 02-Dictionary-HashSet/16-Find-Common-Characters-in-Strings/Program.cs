using System;
using System.Collections.Generic;

namespace Find_Common_Characters_in_Strings
{
    class Program
    {
        private static Dictionary<char, int> CountCharacters(string word)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char ch in word)
            {
                if (!counts.ContainsKey(ch))
                    counts[ch] = 0;

                counts[ch]++;
            }

            return counts;
        }

        private static List<char> FindCommonCharacters(string[] words)
        {
            List<char> result = new List<char>();

            if (words == null || words.Length == 0)
                return result;

            Dictionary<char, int> commonCounts = CountCharacters(words[0]);

            for (int i = 1; i < words.Length; i++)
            {
                Dictionary<char, int> currentCounts = CountCharacters(words[i]);

                // Update commonCounts using the minimum frequency
                foreach (char ch in new List<char>(commonCounts.Keys))
                {
                    if (currentCounts.ContainsKey(ch))
                        commonCounts[ch] = Math.Min(commonCounts[ch], currentCounts[ch]);
                    else
                        commonCounts[ch] = 0;
                }
            }

            // Build the final result from commonCounts
            foreach (KeyValuePair<char, int> pair in commonCounts)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    result.Add(pair.Key);
                }
            }

            return result;
        }


        static void Main()
        {
            string[] words = { "bella", "label", "roller" };

            List<char> result = FindCommonCharacters(words);
            Console.WriteLine("Common Characters: " + string.Join(", ", result));


            Console.ReadKey();
        }

    }
}
