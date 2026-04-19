using System;
using System.Collections.Generic;

namespace Store_Book_Information
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Tuple<string, string>> books = new Dictionary<string, Tuple<string, string>>()
            {
                { "978-0-7352-1129-2", Tuple.Create("Atomic Habits", "James Clear") },
                { "978-1-61-729494-5", Tuple.Create("C# in Depth", "Jon Skeet") },
                { "978-1-59184-644-4", Tuple.Create("The Power of Now", "Eckhart Tolle") },
                { "978-0-135-39857-9", Tuple.Create("Clean Code", "Robert C. Martin") },
                { "978-0-132-35088-4", Tuple.Create("1984", "George Orwell") },
            };


            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value.Item1}, Author: {book.Value.Item2}");
            }



            Console.ReadKey();
        }
    }
}
