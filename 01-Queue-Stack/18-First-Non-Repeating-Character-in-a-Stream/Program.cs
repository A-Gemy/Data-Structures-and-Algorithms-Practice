using System;
using System.Collections.Generic;

namespace First_Non_Repeating_Character_in_a_Stream
{
    class Program
    {

        static void PrintFirstNonRepeatingCharacters(string stream)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            Queue<char> queue = new Queue<char>();
            List<char> result = new List<char>();

            foreach (char ch in stream)
            {
                if (!map.ContainsKey(ch))
                    map[ch] = 0;

                map[ch]++;
                queue.Enqueue(ch);

                while (queue.Count > 0 && map[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }

                result.Add(queue.Count > 0 ? queue.Peek() : '-');
            }

            Console.WriteLine(string.Join(", ", result));
        }

        static void PrintFirstNonRepeatingCharacter(string stream)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char ch in stream)
            {
                if (!map.ContainsKey(ch))
                    map[ch] = 0;

                map[ch]++;
            }

            foreach (char ch in stream)
            {
                if (map[ch] == 1)
                {
                    Console.WriteLine("First Non-Repeating Character: " + ch);
                    return;
                }
            }

            Console.WriteLine("No non-repeating character found.");
        }

        static void Main()
        {
            string input = "aabbcd";

            Console.WriteLine("Input: " + input);

            Console.Write("First non-repeating characters: ");
            PrintFirstNonRepeatingCharacters(input);

            PrintFirstNonRepeatingCharacter(input);




            Console.ReadKey();
        }
    }
}
