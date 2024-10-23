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
            Console.Write("Enter a day of the week (e.g., Monday): )");
            string userInput = Console.ReadLine();

            Day dayOfWeek = (Day)Enum.Parse(typeof(Day), userInput);
            switch (dayOfWeek)
            {
                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine("It's weekend!! Party time!");
                    break;

                case Day.Monday:
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                case Day.Friday:
                    Console.WriteLine("Weekend is loading...");
                    break;

                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
        }
    }
}
