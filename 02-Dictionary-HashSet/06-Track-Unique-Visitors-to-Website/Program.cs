using System;
using System.Collections.Generic;

namespace Track_Unique_Visitors_to_Website
{
    class Program
    {
        static void Main()
        {
            HashSet<string> visitors = new HashSet<string>();

            visitors.Add("192.168.1.1");
            visitors.Add("176.120.77.1");
            visitors.Add("10.0.0.5");
            visitors.Add("176.120.77.1");
            visitors.Add("192.168.1.1");

            Console.WriteLine($"Unique Visitors: {visitors.Count}");
            Console.WriteLine("Visitor IPs:");

            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }


            Console.ReadKey();
        }
    }
}
