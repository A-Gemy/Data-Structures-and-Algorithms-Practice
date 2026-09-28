using System;
using System.Collections;

namespace BitArray_To_Integer
{
    class Program
    {
        private static int ConvertToInteger(BitArray bits)
        {
            int result = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i])
                {
                    result += 1 << i; // Left shift operator
                }
            }

            return result;
        }

        static void Main()
        {
            BitArray bits = new BitArray(new bool[]
            {
                true, false, true, true
            });

            Console.WriteLine($"Bits to integer: {ConvertToInteger(bits)}");


            Console.ReadKey();
        }
    }
}
