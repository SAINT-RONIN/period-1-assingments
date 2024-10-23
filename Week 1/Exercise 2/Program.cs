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
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Next year you will be {age} years old.");
        }
    }
}
