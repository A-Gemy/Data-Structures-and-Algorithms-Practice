using System;
using System.Collections.Generic;

namespace Character_to_Row_Lookup
{
    class Program
    {
        private static readonly Dictionary<char, int> KeyboardRows = BuildKeyboardRows();

        private static Dictionary<char, int> BuildKeyboardRows()
        {
            Dictionary<char, int> keyboardRows = new Dictionary<char, int>();
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

            for (int i = 0; i < rows.Length; i++)
            {
                foreach (char ch in rows[i])
                {
                    keyboardRows[ch] = i;
                }
            }

            return keyboardRows;
        }

        private static bool IsFromOneKeyboardRow(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            char firstChar = char.ToLower(word[0]);

            if (!KeyboardRows.ContainsKey(firstChar))
                return false;

            int row = KeyboardRows[firstChar];

            for (int i = 1; i < word.Length; i++)
            {
                char currentChar = char.ToLower(word[i]);

                if (!KeyboardRows.ContainsKey(currentChar) || KeyboardRows[currentChar] != row)
                    return false;
            }

            return true;
        }

        private static List<string> FindWordsFromOneKeyboardRow(string[] words)
        {
            List<string> result = new List<string>();

            if (words == null || words.Length == 0)
                return result;

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];

                if (IsFromOneKeyboardRow(currWord))
                    result.Add(currWord);
            }

            return result;
        }


        static void Main()
        {
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };

            List<string> result = FindWordsFromOneKeyboardRow(words);
            Console.WriteLine("Words from one keyboard row: " + string.Join(", ", result));


            Console.ReadKey();
        }
    }
}
