using System;
using System.Collections.Generic;

namespace Check_palindrome_using_Stack
{
    internal class Program
    {
        private static bool IsPalindrome(string text)
        {
            if (text == null)
                return false;

            Stack<char> stack = new Stack<char>(text);

            foreach (var ch in text)
            {
                if (ch != stack.Pop())
                    return false;
            }

            return true;
        }

        static void Main()
        {
            string text1 = "madam", text2 = "hello";

            Console.WriteLine("Is Palindrome: ");
            Console.WriteLine($"{text1} -> {IsPalindrome(text1)}");
            Console.WriteLine($"{text2} -> {IsPalindrome(text2)}");


            Console.ReadKey();
        }
    }
}
