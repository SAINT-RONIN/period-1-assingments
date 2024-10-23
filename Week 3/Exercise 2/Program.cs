namespace Exercise_2
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
            Console.Write("Enter a non-negative integer: ");
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFactorial(number);
            if (number < 0)
            {
                Console.WriteLine("Enter a positive integer.");
            }
            else 
            {
                Console.WriteLine($"The factorial of {number} is: {result}");
            }
        }

        int CalculateFactorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
