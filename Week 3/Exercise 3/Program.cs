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
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table of table {number}:");
            PrintMultiplicationTable(number);

        }

        void PrintMultiplicationTable(int number)
        {
            int result = 1;
            for (int i = 1; i <= 10; i++) 
            {
                result = i * number;
                Console.WriteLine($"{i} x {number} = {result}");
            }
        }
    }
}
