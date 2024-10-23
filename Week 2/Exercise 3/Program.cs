namespace Exercise_3
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
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            CheckNumber(number);
         
        }

        void CheckNumber(int number)
        {
            if (number == 0) 
            {
                Console.WriteLine("The number is Zero.");
            }
            else if (number > 0) 
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
        }
    }
}
