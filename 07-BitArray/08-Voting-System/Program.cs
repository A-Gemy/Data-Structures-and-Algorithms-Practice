using System;
using System.Collections;

namespace Voting_System
{
    class Program
    {
        private static (int yesVotes, int noVotes) CountVotes(BitArray votes)
        {
            if (votes == null || votes.Length == 0)
                return (0, 0);

            int yesVotes = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i])
                    yesVotes++;
            }

            int noVotes = votes.Length - yesVotes;

            return (yesVotes, noVotes);
        }

        static void Main()
        {
            // true = Yes, false = No
            BitArray votes = new BitArray(new bool[]
            {
                true, false, true, true,   
                false, true, false, true    
            });

            var result = CountVotes(votes);

            Console.WriteLine($"Yes votes: {result.yesVotes}");
            Console.WriteLine($"No votes: {result.noVotes}");


            Console.ReadKey();
        }
    }
}
