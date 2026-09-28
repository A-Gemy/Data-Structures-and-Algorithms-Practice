using System;
using System.Collections;

namespace BitArray_AND_Operation
{
    class Program
    {
        private static BitArray PerformAnd(BitArray first, BitArray second)
        {
            if (first.Length != second.Length)
                throw new ArgumentException("BitArrays must have the same length!");

            BitArray result = new BitArray(first);
            result.And(second);

            return result;
        }

        static void Main(string[] args)
        {
            BitArray first = new BitArray(new bool[]
            {
                true, false, true, true, false
            });

            BitArray second = new BitArray(new bool[]
            {
                true, true, false, true, false
            });

            BitArray result = PerformAnd(first, second);

            Console.WriteLine("First BitArray:");
            foreach (bool bit in first)
                Console.Write($"{bit} ");

            Console.WriteLine("\n\nSecond BitArray:");
            foreach (bool bit in second)
                Console.Write($"{bit} ");

            Console.WriteLine("\n\nAND Result:");
            foreach (bool bit in result)
                Console.Write($"{bit} ");


            Console.ReadKey();
        }
    }
}
