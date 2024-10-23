using Exercise_6;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("How many votes should be processed: ");
            int numberOfVotes = int.Parse(Console.ReadLine());

            VotingSystem votingSystem = new VotingSystem(numberOfVotes);

            for (int i = 0; i < numberOfVotes; i++)
            {
                Console.WriteLine("Enter your vote (Yes/No): ");
                string voteInput = Console.ReadLine();

                if (voteInput == "yes" || voteInput == "Yes")
                {
                    votingSystem.CastVote(VoteOption.Yes);
                    Console.WriteLine("Vote casted: Yes");
                }
                else if (voteInput == "no" || voteInput == "No")
                {
                    votingSystem.CastVote(VoteOption.No);
                    Console.WriteLine("Vote casted: No");
                }
                else 
                {
                    Console.WriteLine("Invalid vote. Please enter Yes or No.");
                }
            }

            votingSystem.DisplayResults();
        }
    }
}


// Instead of checking for Yes or yes(lowe case) I could do this 

//  if (voteInput.ToLower() == "yes")
//  {
//      votingSystem.CastVote(VoteOption.Yes);
//      Console.WriteLine("Vote casted: Yes");
//  }