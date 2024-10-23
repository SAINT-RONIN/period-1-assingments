using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class VotingSystem
    {
        private VoteOption[] votes;
        private int voteCount;
        
        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            voteCount = 0;
        }

        public void CastVote(VoteOption vote)
        {
            if (voteCount < votes.Length)
            {
                votes[voteCount] = vote;
                voteCount++;
                Console.WriteLine($"Vote casted: {vote}");
            }
            else
            {
                Console.WriteLine("No more votes can be casted.");
            }
        }

        public void DisplayResults()
        {
            int yesVotes = 0;
            int noVotes = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                // Check if the current vote is Yes
                if (votes[i] == VoteOption.Yes)
                {
                    yesVotes++; // Increment yesVotes by 1
                }
                // Check if the current vote is No
                else if (votes[i] == VoteOption.No)
                {
                    noVotes++; // Increment noVotes by 1
                }
            }

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Yes: {yesVotes}");
            Console.WriteLine($"No: {noVotes}");
        }
    }
}
