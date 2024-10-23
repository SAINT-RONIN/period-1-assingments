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
            int result = 0;
            for (int i = 0; i < 4; i++) 
            {
                Random rnd = new Random();
                int number1 = rnd.Next(101, 10000);

                Console.WriteLine($"{number1}, ");
                result = result + number1;
            }
            Console.WriteLine($"Result of the 4 numbers is: {result}");
        }
    }
}
