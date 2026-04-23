using System;
using System.Collections.Generic;

namespace Translate_Words_Between_Languages
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "Hello", "Hola" },
                { "World", "Mundo" },
                { "Goodbye", "Adios" }
            };

            // Console.WriteLine($"Hello in Spanish: {dictionary["Hello"]}");
            // Console.WriteLine($"Goodbye in Spanish: {dictionary["Goodbye"]}");

            foreach (KeyValuePair<string, string> word in dictionary)
            {
                Console.WriteLine($"{word.Key} in Spanish: {word.Value}");
            }


            Console.ReadKey();
        }
    }
}
