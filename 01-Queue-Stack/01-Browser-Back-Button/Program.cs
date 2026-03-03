using System;
using System.Collections.Generic;

namespace Browser_Back_Button
{
    class Program
    {
        static void Main()
        {

            Stack<string> history = new Stack<string>();

            history.Push("Page1");
            history.Push("Page2");
            history.Push("Page3");

            Console.WriteLine("Back from: " + history.Pop());
            Console.WriteLine("Current Page: " + history.Peek());


            Console.ReadKey();
        }
    }
}
