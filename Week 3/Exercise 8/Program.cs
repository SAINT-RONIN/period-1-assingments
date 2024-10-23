namespace Exercise_8
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
            Console.Write("Enter the number of elements: ");
            int count = int.Parse(Console.ReadLine());

            
            int sum = CalculateSum(count);
            Console.WriteLine($"The sum is: {sum}");

            double average = CalculateAverage(sum, count);
            Console.WriteLine($"The sum is: {average}");
        }

        int CalculateSum(int count)
        {
            int result = 0;
            for (int i = 1; i <= count; i++) 
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                result += number;
            }
            return result;
        }

        double CalculateAverage(int sum, int count)
        {
            return (double)sum / count;

        }
    }
}
