namespace Exercise_4
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

            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] names = new string[numberOfStudents];
            int[] grades = new int[numberOfStudents];

            ReadNames(names);
            int highestGrade = GetHighestGradeIndex(grades);
            Console.WriteLine($"Student {names[highestGrade]} has the highest grade: {grades[highestGrade]}");
        }

        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}");
                names[i] = Console.ReadLine();
            }
        }

        void ReadGrades(int[] grades, string[] names)
        {

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Enter grade of {names[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        int GetHighestGradeIndex(int[] grades)
        {
            // Start by assuming the first grade is the highest
            int highestGradeIndex = 0;  

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestGradeIndex])
                {
                    highestGradeIndex = i;
                }
            }
            return highestGradeIndex;
        }
    }
}
