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
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            Console.WriteLine($"Your full name is {firstName} {lastName}");

            Console.ReadKey();
        }
    }
}
