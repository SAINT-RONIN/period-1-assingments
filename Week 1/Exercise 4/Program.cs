namespace Exercise_4
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
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = number + number;

            result = result + 10;

            result = result / 2;

            result -= number;

            Console.WriteLine($"result is {result}");
        }
    }
}
