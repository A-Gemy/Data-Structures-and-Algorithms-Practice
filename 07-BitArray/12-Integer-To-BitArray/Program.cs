using System;
using System.Collections;

namespace Integer_To_BitArray
{
    class Program
    {
        private static BitArray ConvertToBitArray(int number)
        {
            return new BitArray(new[] { number });
        }

        private static string GetBinaryString(BitArray bits)
        {
            string result = "";

            bool leadingZero = true; // To suppress leading zeros

            for (int i = bits.Length - 1; i >= 0; i--)
            {
                if (bits[i])
                {
                    leadingZero = false;
                }
                if (!leadingZero)
                {
                    result += (bits[i] ? "1" : "0");
                }
            }

            if (result == "")
                return "0";

            return result;
        }

        static void Main()
        {
            int number = 13; // Binary: 1101
            BitArray bits = ConvertToBitArray(number);

            Console.WriteLine($"BitArray representation of {number}: {GetBinaryString(bits)}");


            Console.ReadKey();
        }
    }
}
