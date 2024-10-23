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
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter amount of grades to process: ");
            int numberOfGrades = int.Parse(Console.ReadLine());

            int[] grades = new int[numberOfGrades];

            for (int i = 0; i < numberOfGrades; i++) 
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Student student = new Student(name, grades);

            student.DisplayGrades();
            Console.WriteLine($"Average Grade: {student.CalculateAverage():0.00}");
        }
    }
}
