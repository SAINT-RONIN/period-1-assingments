using System.Threading.Channels;

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
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string result = GetGrade(score);
            Console.WriteLine($"Your grade is {result}");
        }

        string GetGrade(int score)
        {
            string result;
            if (score >= 90 && score <= 100)
            {
                result = "A";
            }

            else if (score >= 80 && score <= 89)
            {
                result = "B";
            }

            else if (score >= 70 && score <= 79)
            {
                result = "C";
            }

            else if (score >= 60 && score <= 69)
            {
                result = "D";
            }

            else if (score >= 50 && score <= 59)
            {
                result = "F";
            }
            else
            {
                result = "Invalid score";  // Handle scores outside the valid range
            }

            return result;
        }
    }
}
