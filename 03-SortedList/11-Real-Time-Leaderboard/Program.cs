using System;
using System.Collections.Generic;

namespace Real_Time_Leaderboard
{
    class Program
    {
        private static void AddOrUpdatePlayerScore(SortedList<string, int> leaderboard, string playerName, int score)
        {
            if (leaderboard == null || string.IsNullOrWhiteSpace(playerName))
                return;

            if (leaderboard.ContainsKey(playerName))
                leaderboard[playerName] += score;
            else
                leaderboard.Add(playerName, score);
        }

        private static void DisplayLeaderboard(SortedList<string, int> leaderboard)
        {
            if (leaderboard == null || leaderboard.Count == 0)
            {
                Console.WriteLine("Leaderboard is empty.");
                return;
            }

            foreach (KeyValuePair<string, int> player in leaderboard)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }

        static void Main()
        {
            SortedList<string, int> leaderboard = new SortedList<string, int>();

            AddOrUpdatePlayerScore(leaderboard, "Ahmed", 50);
            AddOrUpdatePlayerScore(leaderboard, "Sara", 30);
            AddOrUpdatePlayerScore(leaderboard, "Omar", 40);
            AddOrUpdatePlayerScore(leaderboard, "Ahmed", 20);

            Console.WriteLine("Real-Time Leaderboard:");
            DisplayLeaderboard(leaderboard);


            Console.ReadKey();
        }
    }
}
