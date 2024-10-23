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
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // If the remainder is 0, it means the number is divisible by 2. 
            // If the remainder is not 0 in other words 0> (1 and above) it means the number is not divisible by 2.

            if (IsEven(number))
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else 
            {
                Console.WriteLine($"{number} is an odd number.");
            }

        }

        bool IsEven(int number)
        {
            // the % stands for modulus operation. It will divide the number by 2 and returns the remainder.
            return number % 2 == 0;
        }
    }
}
