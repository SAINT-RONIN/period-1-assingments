namespace Week_3
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
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            int result = CalculateSum(n);

            if (n < 0) Console.WriteLine("Enter a positive number.");
            else Console.WriteLine($"The sum of natural numbers from 1 to {n} is: {result}");
        }

        int CalculateSum(int n)
        {
            int result = 0;
            result = n * (n + 1) / 2;
            return result;

        }
    }
}
