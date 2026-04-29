using System;
using System.Collections.Generic;

namespace Find_the_Frequency_of_Each_Character
{
    class Program
    {
        private static Dictionary<char, int> CountCharacterFrequency(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            if (string.IsNullOrEmpty(text))
                return result;

            foreach (char ch in text)
            {
                if (!result.ContainsKey(ch))
                    result[ch] = 0;

                result[ch]++;
            }

            return result;
        }

        static void Main()
        {
            string text = "hello";
            Dictionary<char, int> result = CountCharacterFrequency(text);

            foreach (KeyValuePair<char, int> item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
