using System;
using System.Collections.Generic;

namespace Convert_Decimal_To_Binary
{
    class Program
    {
        public static string DecimalToBinary(int Number)
        {
            if (Number == 0)
            {
                return "0";
            }

            Stack<int> BinaryStack = new Stack<int>();

            while (Number > 0)
            {
                int Remainder = Number % 2;
                Number /= 2;
                BinaryStack.Push(Remainder);
            }

            return string.Join("", BinaryStack);
        }

        public static Stack<int> DecimalToBinaryStack(int Number)
        {
            if (Number == 0)
            {
                Stack<int> zeroStack = new Stack<int>();
                zeroStack.Push(0);
                return zeroStack;
            }

            Stack<int> BinaryStack = new Stack<int>();

            while (Number > 0)
            {
                BinaryStack.Push(Number % 2);
                Number /= 2;
            }

            return BinaryStack;
        }

        static void Main()
        {
            // Method returns string
            Console.Write("Binary string: ");
            Console.WriteLine(DecimalToBinary(12));


            // Method returns stack<int>
            Stack<int> BinaryStack = DecimalToBinaryStack(12);

            Console.Write("Binary stack: ");
            while (BinaryStack.Count > 0)
            {
                Console.Write(BinaryStack.Pop());
            }


            Console.ReadKey();
        }
    }
}
