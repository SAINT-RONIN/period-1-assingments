namespace Exercise_5
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
            int[] numbers = new int[100];
            ReadNumbers(numbers);

            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());

            int count = CountSearchValue(numbers, searchValue);
            Console.WriteLine($"Number of occurrences of search value ({searchValue}) is: {count}");

        }

        void ReadNumbers(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write("Enter a number (0=stop): ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                numbers[i] = input;
            }
        }

        int CountSearchValue(int[] numbers, int searchValue)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
