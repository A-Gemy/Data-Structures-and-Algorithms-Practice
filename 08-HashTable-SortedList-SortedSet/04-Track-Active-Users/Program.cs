using System;
using System.Collections.Generic;

namespace Track_Active_Users
{
    class Program
    {
        private static void AddActiveUser(
            SortedList<DateTime, string> activeUsers,
            string username, 
            DateTime loginTime)
        {
            if (activeUsers.ContainsValue(username))
                return;

            if (activeUsers.ContainsKey(loginTime))
                return;

            activeUsers.Add(loginTime, username);
        }

        static void Main()
        {
            SortedList<DateTime, string> activeUsers = new SortedList<DateTime, string>();

            AddActiveUser(activeUsers, "Ahmed", new DateTime(2026, 10, 1, 10, 0, 0));
            AddActiveUser(activeUsers, "Ali", new DateTime(2026, 10, 1, 10, 15, 0));
            AddActiveUser(activeUsers, "Sara", new DateTime(2026, 10, 1, 10, 10, 0));

            Console.WriteLine("Active users:");
            foreach (var user in activeUsers)
            {
                Console.WriteLine($"{user.Value} - {user.Key:HH:mm}");
            }


            Console.ReadKey();
        }
    }
}
