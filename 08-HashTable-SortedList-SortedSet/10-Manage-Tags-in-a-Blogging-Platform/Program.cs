using System;
using System.Collections.Generic;

namespace Manage_Tags_in_a_Blogging_Platform
{
    class Program
    {
        static void Main()
        {
            SortedSet<string> tags = new SortedSet<string>
            {
                "C#",
                "ASP.NET Core",
                "SQL Server",
                "Entity Framework Core",
                "LINQ",
                "Web API",
                "Git",
                "GitHub",
                "Clean Code",
                "REST API",
                "C#",              // Duplicate
                "ASP.NET Core"     // Duplicate
            };

            Console.WriteLine("Blog Tags:");
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }


            Console.ReadKey();
        }
    }
}
