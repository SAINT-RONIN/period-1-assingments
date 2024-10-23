namespace Exercise_5
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
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle (radius);

            circle.DisplayInfo();
        }
    }
}
