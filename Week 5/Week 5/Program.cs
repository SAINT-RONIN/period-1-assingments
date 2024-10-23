namespace Week_5
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
            Console.Write("Enter width: "); 
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());   

            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;

            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
        }
    }
}
