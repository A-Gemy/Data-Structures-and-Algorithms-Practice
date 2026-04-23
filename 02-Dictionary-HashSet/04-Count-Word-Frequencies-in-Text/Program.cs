using System;
using System.Collections.Generic;

namespace Count_Word_Frequencies_in_Text
{
    class Program
    {
        static Dictionary<string, int> CountWordFrequencies(string text, bool caseSensitive = false)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            if (string.IsNullOrEmpty(text))
                return result;

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string currentWord = caseSensitive ? word : word.ToLower();

                if (!result.ContainsKey(currentWord))
                    result[currentWord] = 0;

                result[currentWord]++;
            }

            return result;
        }

        static void Main()
        {
            string text = "Hello hello world hello universe";
            Dictionary<string, int> result = CountWordFrequencies(text);

            foreach (KeyValuePair<string, int> word in result)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }


            Console.ReadKey();
        }
    }
}
