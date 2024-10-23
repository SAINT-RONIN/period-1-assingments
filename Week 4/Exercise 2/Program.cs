namespace Exercise_2
{
    internal class Program
    {

        const int NumberOfElements = 20;
        const int MinValue = 1;
        const int MaxValue = 100;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int[] numbers = new int[NumberOfElements];


        }

        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(MinValue, MaxValue + 1);
            }
        }

        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length; i++)
            {
                // numbers here is actually the one holding the random numbers and i is just position. so i = random number.
                Console.Write($"{numbers[i]:0.00}");
            }
        }
        int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0]; // Assume the first element is the smallest

            // The reason I'm starting from i = 1 is because the i = 0 is already considered with the code above it.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i]; // Update smallest if a smaller value is found
                }
            }
            return smallest;
        }
    }
}
