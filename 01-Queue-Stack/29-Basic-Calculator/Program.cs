using System;
using System.Collections.Generic;

namespace Basic_Calculator
{
    internal class Program
    {
        private static int CalculateExpression(string expression)
        {
            Stack<int> stack = new Stack<int>();

            int result = 0; // current result
            int number = 0; // current number
            int sign = 1;   // 1 for +, -1 for -

            foreach (char ch in expression)
            {
                if (char.IsDigit(ch))
                {
                    // build multi-digit number
                    number = number * 10 + (ch - '0');
                }
                else if (ch == '+')
                {
                    result += sign * number;
                    number = 0;
                    sign = 1;
                }
                else if (ch == '-')
                {
                    result += sign * number;
                    number = 0;
                    sign = -1;
                }
                else if (ch == '(')
                {
                    // save current state
                    stack.Push(result);
                    stack.Push(sign);

                    result = 0;
                    number = 0;
                    sign = 1;
                }
                else if (ch == ')')
                {
                    // finish inner expression
                    result += sign * number;
                    number = 0;

                    int previousSign = stack.Pop();
                    int previousResult = stack.Pop();

                    // combine outer and inner results
                    result = previousResult + previousSign * result;
                }
            }

            result += sign * number; // add last number
            return result;
        }

        static void Main()
        {
            Console.WriteLine(CalculateExpression("1 + (2 - 3)"));
            Console.WriteLine(CalculateExpression("2-(1+2)"));
            Console.WriteLine(CalculateExpression("(1+(4+5+2)-3)+(6+8)"));


            Console.ReadKey();
        }

    }
}
