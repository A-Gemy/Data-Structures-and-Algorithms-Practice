using System;
using System.Collections.Generic;

namespace Evaluate_Postfix_Expression
{
    internal class Program
    {
        private static int PerformOperation(int left, int right, char op)
        {
            switch (op)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    return left / right;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }

        private static int EvaluatePostfix(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Expression cannot be empty.");

            Stack<int> numbers = new Stack<int>();

            foreach (char ch in expression)
            {
                if (char.IsWhiteSpace(ch))
                    continue;

                if (char.IsDigit(ch))
                {
                    int number = ch - '0';
                    numbers.Push(number);
                }
                else
                {
                    if (numbers.Count < 2)
                        throw new InvalidOperationException("Invalid postfix expression.");

                    int right = numbers.Pop();
                    int left = numbers.Pop();

                    numbers.Push(PerformOperation(left, right, ch));
                }
            }

            if (numbers.Count != 1)
                throw new InvalidOperationException("Invalid postfix expression.");

            return numbers.Pop();
        }

        static void Main()
        {
            Console.WriteLine(EvaluatePostfix("231*+9-"));

            Console.ReadKey();
        }

    }
}
