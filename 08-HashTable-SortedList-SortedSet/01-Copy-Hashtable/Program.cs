using System;
using System.Collections;

namespace Copy_Hashtable
{
    class Program
    {
        private static Hashtable CopyHashtable(Hashtable hashTable)
        {
            // var copy = new Hashtable();

            // foreach (DictionaryEntry entry in hashTable)
            // {
            //     copy.Add(entry.Key, entry.Value);
            // }

            // return copy;
            
            return new Hashtable(hashTable);
        }

        static void Main()
        {
            Hashtable hashTable = new Hashtable
            {
                { "Name", "Ahmed" },
                { "Age", 26 },
                { "Country", "Egypt" },
                { "Job", ".NET Developer" }
            };

            var copy = CopyHashtable(hashTable);

            foreach (DictionaryEntry entry in copy)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}
