using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Invalid_Parentheses
{
    class Program
    {
        private static string BuildValidParenthesesString(string text, HashSet<int> invalidIndexes)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (invalidIndexes.Contains(i))
                    continue;

                result.Append(text[i]);
            }
            return result.ToString();
        }

        private static string RemoveInvalidParentheses(string text)
        {
            if (text == null)
                return string.Empty;

            Stack<int> stack = new Stack<int>();
            HashSet<int> invalidIndexes = new HashSet<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push(i);
                }
                else if (text[i] == ')')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else
                        invalidIndexes.Add(i);
                }
            }

            // Remaining '(' in the stack are also invalid
            while (stack.Count > 0)
            {
                invalidIndexes.Add(stack.Pop());
            }

            return BuildValidParenthesesString(text, invalidIndexes);
        }

        static void Main()
        {
            Console.WriteLine(RemoveInvalidParentheses("(()))"));
            Console.WriteLine(RemoveInvalidParentheses("((()"));


            Console.ReadKey();
        }
    }
}
