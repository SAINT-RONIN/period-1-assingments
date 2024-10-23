namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start ()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool result = IsLeapYear(year);

            if (result)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else 
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

        }

        bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }
}
 