using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_a_String
{
    class Program
    {
        static string ReverseString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>(text);

            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }

        static void Main()
        {
            string input = "Hello world";

            Console.WriteLine("Input text: " + input);
            Console.WriteLine("Reversed text: " + ReverseString(input));


            Console.ReadKey();
        }
    }
}
