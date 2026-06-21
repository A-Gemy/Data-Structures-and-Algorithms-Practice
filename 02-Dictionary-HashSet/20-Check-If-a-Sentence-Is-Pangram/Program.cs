using System;
using System.Collections.Generic;

namespace Check_If_a_Sentence_Is_Pangram
{
    class Program
    {
        private static bool IsPangram(string sentence)
        {
            if (sentence == null || sentence.Length == 0) 
                return false;

            HashSet<char> letters = new HashSet<char>();

            foreach (char ch in sentence)
            {
                if (char.IsLetter(ch))
                    letters.Add(char.ToLower(ch));
            }

            return letters.Count == 26;
        }

        static void Main()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            if (IsPangram(sentence))
                Console.WriteLine("The sentence is a pangram.");
            else
                Console.WriteLine("The sentence is not a pangram.");


            Console.ReadKey();
        }
    }
}
