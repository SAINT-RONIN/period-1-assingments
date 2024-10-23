namespace Exercise_3
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
            int[] numbers = new int[3];
            Console.WriteLine("Enter 3 integers: ");

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = CalculateSum(numbers);
            Console.WriteLine($"Sum: {sum}");

            double average = CalculateAverage(numbers);
            Console.WriteLine($"Average: {average}");
        }

        int CalculateSum(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length;
        }
    }
}
