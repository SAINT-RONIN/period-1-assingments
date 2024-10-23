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
            int[] diceCount = new int[6];
            int numberOfThrows = 6000;
        }

        void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfThrows; i++) 
            {
                int diceRoll = random.Next(1, 7);
                diceCounts[diceRoll - 1]++;
            }

            for (int i = 0; i < diceCounts.Length; i++) 
            {
                Console.WriteLine($"Number os throws of value {i + 1} = {diceCounts[i]}");
            }
        }
    }
}
