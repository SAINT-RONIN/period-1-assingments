namespace Exercise_7
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
            Console.Write("Enter a Dimension size: ");
            int dimensionSize = int.Parse(Console.ReadLine());

            PrintSquare(dimensionSize);
        }

        //void PrintSquare(int dimensionSize)
        //{
        //    for (int i = 0; i < dimensionSize; i++)
        //    {
        //        for (int j = 0; j < dimensionSize; j++)
        //        {
        //            if (i == 0 || i == dimensionSize - 1)
        //            {
        //                // First and last rows - print all 'X's
        //                Console.Write("X");
        //            }
        //            else
        //            {
        //                // Middle rows - print 'X' at the first and last columns, spaces in between
        //                if (j == 0 || j == dimensionSize - 1)
        //                {
        //                    Console.Write("X");
        //                }
        //                else
        //                {
        //                    Console.Write(" ");
        //                }
        //            }
        //        }
        //        // Move to the next line after finishing each row
        //        Console.WriteLine();
        //    }

        //}

        void PrintSquare(int dimensionSize)
        {
            for (int i = 0; i < dimensionSize; i++)
            {
                for (int j = 0; j < dimensionSize; j++)
                {
                    if (i == 0 || i == dimensionSize - 1 || j == 0 || j == dimensionSize - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
