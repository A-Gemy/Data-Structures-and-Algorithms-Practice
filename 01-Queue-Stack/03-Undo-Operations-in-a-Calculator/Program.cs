using System;
using System.Collections.Generic;

namespace Undo_Operations_in_a_Calculator
{
    class Calculator
    {
        private readonly Stack<int> history = new Stack<int>();

        private int currentValue;

        public Calculator()
        {
            currentValue = 0;
        }

        public int GetValue()
        {
            return currentValue;
        }

        public void Add(int value)
        {
            history.Push(currentValue);
            currentValue += value;
        }

        public void Subtract(int value)
        {
            history.Push(currentValue);
            currentValue -= value;
        }

        public void Multiply(int value)
        {
            history.Push(currentValue);
            currentValue *= value;
        }

        public void Divide(int value)
        {
            if (value == 0)
            {
                Console.WriteLine("Divide by 0 is not allowed");
                return;
            }
            history.Push(currentValue);
            currentValue /= value;
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                currentValue = history.Pop();
            }
        }

        public void Clear()
        {
            history.Clear();
            currentValue = 0;
        }

    }


    class Program
    {

        static void Main()
        {
            Calculator calculator = new Calculator();

            calculator.Add(5);
            calculator.Multiply(2);
            calculator.Subtract(3);
            calculator.Undo();
            calculator.Undo();

            Console.WriteLine(calculator.GetValue());

            Console.ReadKey();
        }
    }
}
