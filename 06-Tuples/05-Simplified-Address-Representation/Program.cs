using System;

namespace Simplified_Address_Representation
{
    class Program
    {
        private static (string street, string city, string state, string zipCode) GetAddress()
        {
            return ("123 Main St", "Springfield", "IL", "62704");
        }

        static void Main()
        {
            var address = GetAddress();

            Console.WriteLine($"Address: {address.street}, {address.city}, {address.state}, {address.zipCode}");


            Console.ReadKey();
        }
    }
}
