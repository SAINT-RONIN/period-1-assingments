namespace Exercise_9
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

            string result = GetGrade(score);  // Get both grade and feedback
            Console.WriteLine(result);
        }

        string GetGrade(int score)
        {
            string result;
            string feedback;
            if (score >= 90 && score <= 100)
            {
                result = "A";
                feedback = "Excellent work!";
            }

            else if (score >= 80 && score <= 89)
            {
                result = "B";
                feedback = "Good job, but there’s room for improvement.";
            }

            else if (score >= 70 && score <= 79)
            {
                result = "C";
                feedback = "You passed, but consider reviewing the material.";
            }

            else if (score >= 60 && score <= 69)
            {
                result = "D";
                feedback = "Barely passed, you should work harder.";
            }

            else if (score >= 50 && score <= 59)
            {
                result = "F";
                feedback = " Failed, please seek help.";
            }
            else
            {
                result = "Invalid score";  // Handle scores outside the valid range
                feedback = "";
            }

            return $"Your grade is {result}.\nFeedback: {feedback}";
        }
    }
}
