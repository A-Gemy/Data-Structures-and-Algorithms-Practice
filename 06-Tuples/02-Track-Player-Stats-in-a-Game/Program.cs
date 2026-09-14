using System;

namespace Track_Player_Stats_in_a_Game
{
    class Program
    {
        private static (string name, int health, int score) GetPlayerStats()
        {
            return ("Player1", 100, 2000);
        }

        static void Main()
        {
            (string name, int health, int score) player = GetPlayerStats();

            Console.WriteLine($"Player Name: {player.name}");
            Console.WriteLine($"Health: {player.health}");
            Console.WriteLine($"Score: {player.score}");


            Console.ReadKey();
        }
    }
}
