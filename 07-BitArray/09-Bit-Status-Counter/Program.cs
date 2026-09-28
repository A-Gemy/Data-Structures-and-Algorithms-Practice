using System;
using System.Collections;

namespace Bit_Status_Counter
{
    class Program
    {
        private static int CountTrueBits(BitArray bits)
        {
            int count = 0;

            foreach (bool bit in bits)
            {
                if (bit)
                    count++;
            }

            return count;
        }

        private static int CountFalseBits(BitArray bits)
        {
            int count = 0;

            foreach (bool bit in bits)
            {
                if (!bit)
                    count++;
            }

            return count;
        }

        static void Main()
        {
            BitArray bits = new BitArray(new bool[]
            {
                true, false, true, true, false
            });

            Console.WriteLine($"Number of true bits: {CountTrueBits(bits)}");
            Console.WriteLine($"Number of false bits: {CountFalseBits(bits)}");


            Console.ReadKey();
        }
    }
}
