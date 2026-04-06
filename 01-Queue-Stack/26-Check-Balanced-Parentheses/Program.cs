using System;
using System.Collections.Generic;

namespace Check_Balanced_Parentheses
{
    internal class Program
    {
        static bool IsOpeningBracket(char ch)
        {
            return ch == '(' || ch == '{' || ch == '[';
        }

        static bool IsClosingBracket(char ch)
        {
            return ch == ')' || ch == '}' || ch == ']';
        }

        static bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }

        static bool IsBalanced(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in text)
            {
                if (IsOpeningBracket(ch))
                {
                    stack.Push(ch);
                }
                else if (IsClosingBracket(ch))
                {
                    if (stack.Count == 0)
                        return false;

                    char opening = stack.Pop();

                    if (!IsMatchingPair(opening, ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }


        static bool IsBalancedUsingDictionary(string text)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char ch in text)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (bracketPairs.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[ch])
                        return false;
                }
            }

            return stack.Count == 0;
        }


        static bool IsBalancedUsingExpectedClosings(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in text)
            {
                if (ch == '(')
                    stack.Push(')');
                else if (ch == '{')
                    stack.Push('}');
                else if (ch == '[')
                    stack.Push(']');
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != ch)
                        return false;
                }
            }

            return stack.Count == 0;
        }


        static void Main()
        {
            string validText = "({[]})";
            string invalidText = "({[)]}";

            Console.WriteLine("Using Helpers:");
            Console.WriteLine(IsBalanced(validText));
            Console.WriteLine(IsBalanced(invalidText));

            Console.WriteLine();

            Console.WriteLine("Using Dictionary:");
            Console.WriteLine(IsBalancedUsingDictionary(validText));
            Console.WriteLine(IsBalancedUsingDictionary(invalidText));

            Console.WriteLine();

            Console.WriteLine("Using Expected Closings:");
            Console.WriteLine(IsBalancedUsingExpectedClosings(validText));
            Console.WriteLine(IsBalancedUsingExpectedClosings(invalidText));


            Console.ReadKey();
        }
    }
}
