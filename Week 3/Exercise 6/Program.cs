namespace Exercise_6
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
            Console.Write("Enter a positive integer greater than 1: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number) == true)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else 
            {
                Console.WriteLine($"{number} is not a prime number.");
            }


        }

        bool IsPrime(int number)
        {
            if (number <= 1) 
            {
                Console.WriteLine("Invalid number, enter a positive integer greater than 1.");
                return false;
            }

            // The reason why i = starts at 2 is because 2 is the smallest prime number, and prime numbers are only divisible by 1 and themselves. So, you begin checking from 2 onward.
            // i * i <= number what it does is that it check the number up to a sqaure root. For example if I enter 13 it check 2 * 2 = 4 and 4 is less than 13 so the loop continues.
            for (int i = 2; i * i <= number; i++) 
            {
                // Here I'm cheching if the the number is divisible by the i(index).
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
