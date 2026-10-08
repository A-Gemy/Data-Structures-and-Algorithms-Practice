using System;
using System.Collections.Generic;

namespace Track_Unique_Items_in_Shopping_Cart
{
    class Program
    {
        static void Main()
        {
            SortedSet<string> shoppingCart = new SortedSet<string>
            {
                "Grapes",
                "Banana",
                "Orange",
                "Apple",
                "Milk",
                "Apple"
            };

            Console.WriteLine("Items in the shopping cart:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
